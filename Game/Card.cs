using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public enum Suit { Spade, Diamond, Heart, Club} 
    internal class Card
    {
        //масть карты
        //номер карты

        public int CardRank { get; set; }
        public Suit CardSuit { get; set; }    
        public bool isTrump { get; set; }

        public Card(int cardRank, Suit cardSuit)
        {
            CardRank = cardRank;
            CardSuit = cardSuit;
            this.isTrump = false; 
        }
    }
}
