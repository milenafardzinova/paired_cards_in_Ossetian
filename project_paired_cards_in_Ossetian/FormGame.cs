using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using static project_paired_cards_in_Ossetian.GameField;

namespace project_paired_cards_in_Ossetian
{
    public partial class FormGame : Form
    {
        private GameField gameField;
        private PlayerData currentPlayer;
        private string selectedTheme;
        private int selectedLevel;
        public static bool IsSoundEnabled { get; set; } = true;

        public FormGame(PlayerData player, string theme, int level)
        {
            InitializeComponent();
            this.currentPlayer = player;
            this.selectedTheme = theme;
            this.selectedLevel = level;
        }

        private void FormGame_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;//чтобы при перевороте карточек экран не мерцал
            gameField = new GameField(selectedTheme, selectedLevel);
            CreateField();
        }

        private void CreateField()
        {
            
            dataGridViewField.Rows.Clear();

            int cellSize = 105;

            dataGridViewField.RowTemplate.Height = cellSize;
            for (int i = 0; i < 4; i++)
            {
                dataGridViewField.Rows.Add();
            }
            dataGridViewField.Width = (cellSize * 4) + 3;
            dataGridViewField.Height = (cellSize * 4) + 3;

            string backPath = "images/cards/back.jpg";
            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    Card card = gameField.GetCardAt(row, col);
                    Image back = Image.FromFile(backPath);
                    dataGridViewField[col,row].Value = back;
                }
            }
        }

        //добавила ключевое слово async, чтобы можно было ждать нужное кол-во мс(работает как таймер)
        private async void dataGridViewField_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int row = e.RowIndex;
            int col = e.ColumnIndex;

            Card clickedCard = gameField.GetCardAt(row, col);
            if (clickedCard.IsMatched) return;
            if (clickedCard.IsOpened)
            {
                //clickedCard.PlayVoice(); МЕТОД ДЛЯ ПОВТОРНОЙ ОЗВУЧКИ УЖЕ ОТКРЫТОЙ КАРТЫ(у которой нет пары)
                dataGridViewField.ClearSelection();//убираем синее выделение ячейки
                return;
            }

            TurnResult result = gameField.SelectCard(clickedCard);
            dataGridViewField[col, row].Value = clickedCard.Image;
            //clickedCard.PlayVoice();
            dataGridViewField.ClearSelection();

            switch (result)
            {
                case TurnResult.FirstCardOpened:
                    break;

                case TurnResult.MatchFound:
                    if (gameField.CheckWinCondition())
                    {
                        MessageBox.Show($"Поздравляем, {currentPlayer.Name}! Вы победили!");

                        if (selectedTheme == "Animals")
                        {
                            if (selectedLevel == currentPlayer.MaxUnlockedAnimals && currentPlayer.MaxUnlockedAnimals < 3)
                            {
                                currentPlayer.MaxUnlockedAnimals++;
                            }
                        }
                        else if (selectedTheme == "Food")
                        {
                            if (selectedLevel == currentPlayer.MaxUnlockedFood && currentPlayer.MaxUnlockedFood < 3)
                            {
                                currentPlayer.MaxUnlockedFood++;
                            }
                        }

                        var repository = FormChooseTheme.ReadFromFile("saves.json");
                        repository.Add(currentPlayer);

                        string json = JsonSerializer.Serialize(repository);

                        StreamWriter sw = new StreamWriter("saves.json");
                        sw.Write(json);
                        sw.Close();
                        this.Close();
                    }
                    gameField.ResetTurn();//очищает ссылки на первую и вторую открытую карту(чтобы повторно были новые первая и вторая карта)
                    break;

                case TurnResult.WrongPair:
                    //блокируем доступ щелчком, чтоб нельзя было открыть больше 2 карт
                    dataGridViewField.Enabled = false;

                    // ждем 600 мс, чтобы карты не сразу закрылись
                    await Task.Delay(600);

                    gameField.CloseUnmatchedCards();
                    CloseUnmatchedCardsOnScreen();
                    dataGridViewField.Enabled = true;//открываем доступ к щелчкам

                    break;
            }
        }

        private void CloseUnmatchedCardsOnScreen()
        {
            string backPath = "images/cards/back.jpg";

            Image back = Image.FromFile(backPath);

            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    Card card = gameField.GetCardAt(row,col);
                    if (!card.IsMatched)
                    {
                        dataGridViewField[col, row].Value = back;
                    }
                }
            }
        }
    }
}
