using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_paired_cards_in_Ossetian
{
    public partial class FormGame : Form
    {
        
        private Timer flipTimer = new Timer();
        private GameField gameField = new GameField();
        public FormGame()
        {
            InitializeComponent();
            
        }

        private void FormGame_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;//чтобы при перевороте карточек экран не мерцал
            CreateField();
        }

        private void CreateField()
        {
            
            //dataGridViewField.Columns.Clear();
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
                    dataGridViewField[row, col].Value = back;
                }
            }
        }

        private void dataGridViewField_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int col = e.ColumnIndex;

            Card clickedCard = gameField.GetCardAt(row, col);
            clickedCard.Open();
            dataGridViewField[col,row].Value = clickedCard.Image;
            dataGridViewField.ClearSelection();//убираем синее выделение ячейки

        }
    }
}
