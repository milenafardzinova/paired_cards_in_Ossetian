using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_paired_cards_in_Ossetian
{
    public class PlayerData
    {
        public static string Name { get; set;  }
        public static string SelectedTheme {  get; set; }
        public static int SelectedLevel { get; set;  }
        public static int MaxUnlockedLevel {  get; set; }
        public static bool IsSoundEnabled { get; set; } = true;
    }
}
