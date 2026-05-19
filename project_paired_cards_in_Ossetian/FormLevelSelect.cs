using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_paired_cards_in_Ossetian
{
    public partial class FormLevelSelect : Form
    {
        public FormLevelSelect()
        {
            InitializeComponent();
        }

        private void FormLevelSelect_Load(object sender, EventArgs e)
        {
            labelLevelSelect.Parent = pictureBoxBackground;
        }

        private void LevelSelectBotton_Click(object sender, EventArgs e)
        {
            FormGame formGame = new FormGame();
            formGame.Show();
            this.Hide();
        }
    }
}
