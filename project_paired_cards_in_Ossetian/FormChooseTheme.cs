using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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

        public static UsersRepository ReadFromFile(string fileName)
        {
            StreamReader sr = new StreamReader(fileName);
            var jsonStr = sr.ReadToEnd();
            sr.Close();
            return JsonSerializer.Deserialize<UsersRepository>(jsonStr);
        }

        private void ThemeButton_Click(object sender, EventArgs e)
        {
            string userName = textBoxName.Text;
            if (string.IsNullOrEmpty(textBoxName.Text))
            {
                MessageBox.Show("Введите Ваше имя");
                return;
            }
            string selectedTheme = "Food";
            if ((Button)sender == buttonAnimals) 
                selectedTheme = "Animals";

            UsersRepository repository = ReadFromFile("saves.json");
            PlayerData player = new PlayerData(userName, 1);
            repository.Add(player);

            FormLevelSelect levelForm = new FormLevelSelect(player, selectedTheme);
            this.Hide();
            levelForm.ShowDialog();
            this.Show();
        }
    }
}
