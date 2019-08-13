using System;
using System.Collections.Generic;
using System.Linq;
using Suits = WPFCribbage.Card.Suits;
using Ranks = WPFCribbage.Card.CardRank;
using System.ComponentModel;

namespace WPFCribbage 
{
    
    /// <summary>
    /// The deck of cards used for playing the game. 
    /// </summary>
    public class Deck : INotifyPropertyChanged
    {
        /// <summary>
        /// Handles the notifying of property change.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;


        /// <summary>
        /// Gets the cards that are ready for play
        /// </summary>
        public List<Card> DeckofCards { get; set; }

        /// <summary>
        /// Holds the cards that have been discarded
        /// </summary>
        public List<Card> DiscardedCards { get; set; }

        /// <summary>
        /// The constructor. Builds the deck using suit and rank enums.
        /// </summary>
        public Deck()
        {
            DeckofCards = new List<Card>();  // create a list where the cards can be held
            DiscardedCards = new List<Card>(); // create a pile where cards can be discarded

            foreach (string suit in Enum.GetNames(typeof(Suits))) // loop through each suit
            {
                foreach (var rank in Enum.GetValues(typeof(Ranks))) // loop through each rank
                {
                    DeckofCards.Add(new Card((int)rank, suit));  // add a new card to the deck based on its suit and rank
                }
            }
        }

        

        /// <summary>
        /// Shuffles the deck using Fisher-Yates algorithm. 
        /// </summary>
        /// <returns>A shuffled deck of cards</returns>
        public List<Card> Shuffle()
        {
            // place all of the cards back into the deck; 
            DeckofCards.AddRange(DiscardedCards);

            // Use Fisher-Yates algorithm to evenly shuffle deck
            Random r = new Random((int)DateTime.Now.ToBinary());  // ensure the seed is changes
            int n = DeckofCards.Count; // number of cards left in the deck
            while (n > 1)   // loop the deck until all cards have been touched
            {
                int k = r.Next(n);   // grab a random number where 0 <= k < n
                n--;                // take one card out of shuffle
                Card temp = DeckofCards[n];  // grab a card
                DeckofCards[n] = DeckofCards[k];    // store it in deck[n]'s spot
                DeckofCards[k] = temp;       // store the temp card in deck[k]'s spot
            }
            return DeckofCards;   // return the shuffled deck
        }

        /// <summary>
        /// Deals a number of cards based on the number specified.
        /// </summary>
        /// <param name="numberOfCards">The number of cards you want dealt</param>
        /// <returns>A list of the cards dealt</returns>
        public List<Card> Deal(int numberOfCards)
        {
            List<Card> DealtCards = new List<Card>();  // create a holding list

            for(int i = 0; i < numberOfCards; i++)  // loop through as many times as cards that are needed
            {
                Card drawn = DeckofCards.First();  // draw a card

                DealtCards.Add(drawn);  // put it in the holding list

                DeckofCards.Remove(drawn);  // remove it from the deck
            }

            return DealtCards;  // return the holding list to the player
        }
    }
}
