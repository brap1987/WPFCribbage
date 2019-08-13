using System.Collections.Generic;
using System.ComponentModel;

namespace WPFCribbage
{
    public class Player : INotifyPropertyChanged
    {
        /// <summary>
        /// Handles notification of property changes
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Identifies if the player is an actual player or is a bot
        /// </summary>
        public PlayerType Type { get; set; }

        /// <summary>
        /// Unique identifier
        /// </summary>
        public string GamerTag { get; set; }

        /// <summary>
        /// Player's first name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Player's last name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Holds the players score
        /// </summary>
        public int Score { get; set; }

        /// <summary>
        /// Holds player's partner
        /// </summary>
        public Player Teammate { get; set; }

        /// <summary>
        /// Identifies if the player is the dealer
        /// </summary>
        public bool IsDealer { get; set; }

        /// <summary>
        /// Player's crib if they are the dealer
        /// </summary>
        public List<Card> Crib { get; set; }

        /// <summary>
        /// Player's current hand
        /// </summary>
        public List<Card> Hand { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="GamerTag"></param>
        public Player(string GamerTag )
        {
            this.GamerTag = GamerTag;
        }
    }

    /// <summary>
    /// Identifies if player is a player or a bot 
    /// </summary>
    public enum PlayerType
    {
        Player, Computer
    }
}
