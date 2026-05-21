using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_paired_cards_in_Ossetian
{
    public class GameField
    {
        private Card[,] cardGrid = new Card[4, 4];
        private List<Card> cards = new List<Card>();

        private Random rnd = new Random();
        public Card FirstSelectedCard {  get; private set; }
        public Card SecondSelectedCard { get; private set; }

        public GameField()
        {
            CreateField();
        }

        private List<string> GetCardNamesFromfolder()//возвращает список имнен всех картинок
        {
            List<string> cardNames = new List<string>();
            string theme = PlayerData.SelectedTheme;
            int level = PlayerData.SelectedLevel;

            string folderpath = $"images/cards/russian/{theme}/{level}Level";
            string[] fullPaths = Directory.GetFiles(folderpath, "*.png");

            foreach(string path in fullPaths)
            {
                string name = Path.GetFileNameWithoutExtension(path);
                cardNames.Add(name);
            }
            return cardNames;
        }

        private void LoadLanguageCardPairs()
        {
            cards.Clear();
            List<string> allNames = GetCardNamesFromfolder();
            Random rnd = new Random();
            List<string> selectedNames = new List<string>();

            while(selectedNames.Count<8)
            {
                string name = allNames[rnd.Next(allNames.Count)];
                if(!selectedNames.Contains(name))
                    selectedNames.Add(name);
            }



            for(int i = 0;i< 8;i++)
            {
                Card russianCard = new Card(selectedNames[i], "russian");
                Card ossetianCard = new Card(selectedNames[i], "ossetian");

                cards.Add(russianCard);
                cards.Add(ossetianCard);
            }
        }


        private void ShuffledCards() //перемешивает список карт, чтобы потом преобразовать его в двумекрный массив с рандомным расположением карт
        {
            for (int i = cards.Count - 1; i > 0; i--)
            {
                int j = rnd.Next(i + 1);
                Card temp = cards[i];
                cards[i] = cards[j];
                cards[j] = temp;
            }
        }


        private void CreateField()//заполняем двумерную матрицу уже перемешанными картами
        {
            LoadLanguageCardPairs();
            ShuffledCards();
            int index = 0;
            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    if (index <cards.Count)
                    {
                        cardGrid[row, col] = cards[index];
                    }
                    index++;
                }
            }
        }

        public Card GetCardAt(int row, int col)
        {
            return cardGrid[row, col];
        }
    }
}
