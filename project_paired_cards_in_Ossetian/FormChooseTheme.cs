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
    public partial class FormChooseTheme : Form
    {
        public FormChooseTheme()
        {
            InitializeComponent();
        }

        private void FormChooseTheme_Load(object sender, EventArgs e)
        {
            //связываем лейблы с картинкой, чтоб лейблы были прозрачными
            labelName.Parent = pictureBoxBackground;
            labelThemeTitle.Parent = pictureBoxBackground;
        }

        private void ThemeButton_Click(object sender, EventArgs e)
        {
            FormLevelSelect levelForm = new FormLevelSelect();
            levelForm.Show();
            this.Hide();
        }
    }
}
