using System;
using System.Collections.Generic;

namespace TwentyOne
{
    public class Player
    {
        public List<Card> Hand { get; set; }
        public int Balance { get; set; }
        public string Name { get; set; }
        public int Bet { get; set; }

        public Player()
        {
            Hand = new List<Card>();
        }

        public bool PlaceBet(int amount)
        {
            if (amount <= Balance)
            {
                Bet = amount;
                Balance -= amount;
                return true;
            }
            return false;
        }
    }
}
