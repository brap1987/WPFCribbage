using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFCribbage
{
    class Game
    {
        public Player Winner { get; set; }
        public int NumDecks { get; set; }
        public int NumPlayers { get; set; }
        public CardType Deck { get; set; }
        public bool IsDealer { get; set; }

        public Game(int Decks, int Players, CardType Cards)
        {
            if (Decks < 1) // check for number of decks
                throw new Exception("Less than one deck");

            if (Players < 2) // check for number of players
                throw new Exception("Less than two players");

            if (Cards == null)
                throw new Exception("Card type is null");
            

            NumDecks = Decks;
            NumPlayers = Players;
        }







    }
}
