using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Suits = WPFCribbage.Card.Suits;

namespace WPFCribbage
{
    public class Deck
    {
        private Card[] cards;

        public Deck()
        {
            cards = new Card[52];  // create an empty card array
            int index = 0;

            foreach (string suit in Enum.GetNames(typeof(Suits))) // loop through each suit
            {
                for(int i = 1; i <= 13; i++)  // loop through each rank per suit
                {
                    cards[index] = new Card(i, suit);   // create card using rank and suit values 
                }
            }
        }

        private Card[] Shuffle(Card[] deck)
        {
            // Use Fisher-Yates algorithm to evenly shuffle deck
            Random r = new Random((int)DateTime.Now.ToBinary());  // ensure the seed is changes
            int n = deck.Length; // number of cards left in the deck
            while(n > 1)   // loop the deck until all cards have been touched
            {
                int k = r.Next(n);   // grab a random number where 0 <= k < n
                n--;                // take one card out of shuffle
                Card temp = deck[n];  // grab a card
                deck[n] = deck[k];    // store it in deck[n]'s spot
                deck[k] = temp;       // store the temp card in deck[k]'s spot
            }
            return deck;   // return the shuffled deck
        }
    }
}
