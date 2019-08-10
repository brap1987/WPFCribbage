using System;

namespace WPFCribbage
{
    /// <summary>
    /// An individual card that is placed in the deck
    /// </summary>
    public class Card
    {
        /// <summary>
        /// The stored number value of the card. 1,2,3...
        /// </summary>
        public int RankValue { get; set; }

        /// <summary>
        /// The stored suit of the card. Heart, Spade....
        /// </summary>
        public string Suit { get; set; }

        /// <summary>
        /// the enum of the suit of the cards
        /// </summary>
        public enum Suits
        {
            Hearts,
            Spades,
            Clubs,
            Diamonds
        }
        /// <summary>
        /// the enum of the rank of the cards
        /// </summary>
        public enum CardRank
        {
            Ace = 1,
            Two,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            Ten,
            Jack,
            Queen,
            King
        }
        
        /// <summary>
        /// Creates a card with a specific rank and suit.
        /// </summary>
        /// <param name="rankValue">The value of the card</param>
        /// <param name="suit">The suit of the card</param>
        public Card(int rankValue, string suit)
        {
            RankValue = rankValue;  // the rank
            Suit = suit;    /// the suit
        }

        /// <summary>
        /// Override the ToString method to allow the return of "Rank of Suit" string instead. 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Enum.GetName(typeof(CardRank), RankValue) + " of " + Suit; 
        }
    }
}
