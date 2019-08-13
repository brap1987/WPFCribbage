using System.Collections.Generic;

namespace WPFCribbage
{
    public class Player
    {
        public string GamerTag { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Card> Hand { get; set; }

        public Player(string GamerTag )
        {
            
        }
    }


}
