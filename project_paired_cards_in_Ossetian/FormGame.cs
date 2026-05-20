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
        private Card[,] cardGrid = new Card[4, 4];
        private List<Card> cards = new List<Card>();
        private Timer flipTimer = new Timer();
        public FormGame()
        {
            InitializeComponent();
            CreateField();
        }

        private void FormGame_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;//чтобы при перевороте карточек экран не мерцал

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
            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    // Показываем рубашку в ячейке
                    dataGridViewField[col, row].Value = (Image.FromFile("images/back.jpg"));
                }
            }
        }
    }
}
