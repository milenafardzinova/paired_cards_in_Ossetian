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
        private PlayerData currentPlayer;
        private string theme;
        public FormLevelSelect(PlayerData player, string selectedTheme)
        {
            InitializeComponent();
            this.currentPlayer = player;
            this.theme = selectedTheme;
        }

        private void FormLevelSelect_Load(object sender, EventArgs e)
        {
            labelLevelSelect.Parent = pictureBoxBackground;

            int currentThemeMaxLevel = 1;
            if (theme == "Animals")
            {
                currentThemeMaxLevel = currentPlayer.MaxUnlockedAnimals;
            }
            else if (theme == "Food")
            {
                currentThemeMaxLevel = currentPlayer.MaxUnlockedFood;
            }

            if (currentThemeMaxLevel >= 2)
            {
                buttonMiddleLevel.Enabled = true;
                buttonMiddleLevel.BackColor = Color.NavajoWhite;
            }
            else
            {
                buttonMiddleLevel.Enabled = false;
                buttonMiddleLevel.BackColor = Color.DarkGray;
            }

            if (currentThemeMaxLevel >= 3)
            {
                buttonHardLevel.Enabled = true;
                buttonHardLevel.BackColor = Color.NavajoWhite; 
            }
            else
            {
                buttonHardLevel.Enabled = false;
                buttonHardLevel.BackColor = Color.DarkGray; 
            }
        }

        private void LevelSelectBotton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            int selectedLevel;
            if (clickedButton == buttonEasyLevel)
                selectedLevel = 1;
            else if (clickedButton == buttonMiddleLevel)
                selectedLevel = 2;
            else
                selectedLevel = 3;


            FormGame formGame = new FormGame(currentPlayer, theme, selectedLevel);
            this.Hide();
            formGame.ShowDialog();
            this.Close();
        }
    }
}
