using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Game
    {
        public List<Card> CreateDeck()
        {
            List<Card> cards = new List<Card>();
            for (int i = 6; i < 15; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    cards.Add(new Card(i, (Suit)j));
                }
            }

            //foreach (var item in (Suit[])Enum.GetValues(typeof(Suit)))
            //{
            //    for (int i = 6; i < 15; i++)
            //    {
            //            cards.Add(new Card(i, (Suit)j));
            //    }
            //}

            return cards;
        }

        public List<Card> ShuffleDeck(List<Card> deck)
        {
            Random random = new Random();

            int shuffles = random.Next(1, 80);

            for (int i = 0; i < shuffles; i++)
            {
                for (int j = 0; j < 36; j++)
                {

                }
            }
        }

        public void Deal(List<Player> players)
        {
            List<Card> CardDeck = CreateDeck();
            int count = players.Count;
            int i = 0;
            foreach (var item in CardDeck)
            {
                players[i].CardDeck.Add(item);
                i++;

                if (i <= count)
                    i++;
                else
                    i = 0;
            }
        }
    }
}
