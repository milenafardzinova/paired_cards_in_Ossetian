using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_paired_cards_in_Ossetian
{
    public class GameField
    {
        private Card[,] cardGrid = new Card[4, 4];
        private List<Card> cards = new List<Card>();

        private Random rnd = new Random();
        private string currentTheme;
        private int currentLevel;
        public Card FirstSelectedCard {  get; private set; }
        public Card SecondSelectedCard { get; private set; }

        public enum TurnResult
        {
            FirstCardOpened,//открыта только первая карта
            MatchFound,//открыта вторая карта и пары совпали
            WrongPair //открыта вторая карта и карты разные
        }

        public GameField(string theme, int level)
        {
            this.currentTheme = theme;
            this.currentLevel = level;
            CreateField();
        }

        private List<string> GetCardNamesFromfolder()//возвращает список имнен всех картинок
        {
            List<string> cardNames = new List<string>();
            string theme = currentTheme;
            int level = currentLevel;

            string folderpath = $"images/cards/russian/{theme}/{level}Level";
            string[] fullPaths = Directory.GetFiles(folderpath, "*.png");

            foreach(string path in fullPaths)
            {
                string name = Path.GetFileNameWithoutExtension(path);
                cardNames.Add(name);
            }
            return cardNames;
        }

        private void LoadLanguageCardPairs()//добавляет в список карт 8 рандомных карт и их пары
        {
            cards.Clear();
            List<string> allNames = GetCardNamesFromfolder();
            Random rnd = new Random();
            List<string> selectedNames = new List<string>();

            while(selectedNames.Count<8)
            {
                string name = allNames[rnd.Next(allNames.Count)];
                if(!selectedNames.Contains(name))
                    selectedNames.Add(name);
            }



            for(int i = 0;i< 8;i++)
            {
                Card russianCard = new Card(selectedNames[i], "russian", currentTheme, currentLevel);
                Card ossetianCard = new Card(selectedNames[i], "ossetian", currentTheme, currentLevel);

                cards.Add(russianCard);
                cards.Add(ossetianCard);
            }
        }


        private void ShuffledCards() //перемешивает список карт, чтобы потом преобразовать его в двумекрный массив с рандомным расположением карт
        {
            for (int i = cards.Count - 1; i > 0; i--)
            {
                int j = rnd.Next(i + 1);
                Card temp = cards[i];
                cards[i] = cards[j];
                cards[j] = temp;
            }
        }


        private void CreateField()//заполняем двумерную матрицу уже перемешанными картами
        {
            LoadLanguageCardPairs();
            ShuffledCards();
            int index = 0;
            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    if (index <cards.Count)
                    {
                        cardGrid[row, col] = cards[index];
                    }
                    index++;
                }
            }
        }

        public Card GetCardAt(int row, int col)
        {
            return cardGrid[row, col];
        }

        public void ResetTurn()
        {
            FirstSelectedCard = null;
            SecondSelectedCard = null;
        }

        public TurnResult SelectCard(Card clickedCard)
        {
            if (FirstSelectedCard == null)
            {
                FirstSelectedCard = clickedCard;
                FirstSelectedCard.Open();

                return TurnResult.FirstCardOpened;
            }

            //если это вторая открытая карта в этом ходе
            SecondSelectedCard = clickedCard;
            SecondSelectedCard.Open();

            if (FirstSelectedCard.IsPairFor(SecondSelectedCard))
            {
                FirstSelectedCard.MarkAsMatched();
                SecondSelectedCard.MarkAsMatched();
                return TurnResult.MatchFound;
            }

            //иначе карты разные
            return TurnResult.WrongPair;
        }

        public bool CheckWinCondition()
        {
            foreach (Card card in cardGrid)
            {
                //если нашли карточку, у которой пара еще не найдена, значит продолжаем игру
                if (card != null && !card.IsMatched)
                {
                    return false;
                }
            }
            //иначе победа
            return true;
        }

        public void CloseUnmatchedCards()
        {
            if (FirstSelectedCard != null) FirstSelectedCard.Close(); 
            if (SecondSelectedCard != null) SecondSelectedCard.Close();
            ResetTurn();
        }
    }
}
