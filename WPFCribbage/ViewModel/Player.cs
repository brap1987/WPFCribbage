using System.Collections.Generic;

namespace WPFCribbage
{
    public class Player
    {
        /// <summary>
        /// 
        /// </summary>
        public string GamerTag { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<Card> Hand { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="GamerTag"></param>
        public Player(string GamerTag )
        {
            
        }
    }
}
