using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace project_paired_cards_in_Ossetian
{
    public class SoundManager
    {
        private static SoundPlayer player = new SoundPlayer();

        public static void PlayVoice(Card card)
        {
            if(!FormGame.IsSoundEnabled) return;

            if (card.Language == "russian") return;

            string soundPath = $"sounds/{card.CardTheme}/{card.Name}.wav";
            player.SoundLocation = soundPath;
            player.Play();
        }
    }
}
