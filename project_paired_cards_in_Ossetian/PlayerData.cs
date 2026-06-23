using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_paired_cards_in_Ossetian
{
    public class PlayerData
    {
        public string Name { get; set;  }
        public int MaxUnlockedAnimals { get; set; } = 1;
        public int MaxUnlockedFood { get; set; } = 1;
        public PlayerData() { }
        public PlayerData(string name, int defaultLevel)
        {
            this.Name = name;
            this.MaxUnlockedAnimals = defaultLevel;
            this.MaxUnlockedFood = defaultLevel;
        }
        public void Update(PlayerData newPlayerData)
        {
            if (this.MaxUnlockedAnimals < newPlayerData.MaxUnlockedAnimals)
            {
                this.MaxUnlockedAnimals = newPlayerData.MaxUnlockedAnimals;
            }

            if (this.MaxUnlockedFood < newPlayerData.MaxUnlockedFood)
            {
                this.MaxUnlockedFood = newPlayerData.MaxUnlockedFood;
            }
        }
    }
}
