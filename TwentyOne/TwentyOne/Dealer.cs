using System;
using System.Collections.Generic;

namespace TwentyOne
{
    public class Dealer : Player
    {
        public Deck Deck { get; set; }

        public void Deal(Player player)
        {
            player.Hand.Add(Deck.Cards[0]);
            Deck.Cards.RemoveAt(0);
            Console.WriteLine("Dealing...");
            System.Threading.Thread.Sleep(1000); // Adding delay for dealing effect
        }
    }
}
