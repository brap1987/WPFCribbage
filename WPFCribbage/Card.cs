using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFCribbage
{
    public class Card
    {
        public enum Suits
        {
            Hearts ,
            Spades,
            Clubs,
            Diamonds
        }
        private int _rankValue;
        private string _suit;

        public Card(int rankValue, string suit)
        {
            RankValue = rankValue;
            Suit = suit;
        }

        public int RankValue { get => _rankValue; set => _rankValue = value; }
        public string Suit { get => _suit; set => _suit = value; }
    }
}
