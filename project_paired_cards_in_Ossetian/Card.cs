using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace project_paired_cards_in_Ossetian
{
    public class Card
    {
        public string Name { get; set; }
        public string Language { get; set; }
        public Image Image { get; set; }
        public bool IsOpened { get; private set; }  = false; 
        public bool IsMatched { get; private set; }

        public Card(string name,string language) 
        { 
            Name= name;
            Language= language;
            string path = GetImagePath();
            //если существует путь к файлу, то выводить картинку, иначе показываем рубашку
            if (File.Exists(path))
            {
                Image = Image.FromFile(path);
            }
            else
                Image = Image.FromFile("images/cards/back.jpg");

        }

        public string GetImagePath()
        {
            string theme = PlayerData.SelectedTheme;
            int level = PlayerData.SelectedLevel;
            if (level == 3 && Language == "ossetian")
            {
                level = 2;
            }
            string path = $"images/cards/{Language}/{theme}/{level}Level/{Name}.png";
            return path ;
        }
        public void Open()
        {
            if (!IsMatched) IsOpened = true;
        }

        public void Close()
        {
            if (!IsMatched) IsOpened = false;
        }

        public void MarkAsMatched()
        {
            IsMatched = true;
            IsOpened = true;
        }

        public bool IsPairFor(Card otherCard)
        {
            return this.Name==otherCard.Name && this != otherCard;
        }


    }
}
