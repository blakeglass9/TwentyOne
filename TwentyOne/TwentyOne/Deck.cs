using System;
using System.Collections.Generic;

namespace TwentyOne
{
    public class Deck
    {
        private static readonly string[] Suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
        private static readonly string[] Values = { "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace" };

        public List<Card> Cards { get; private set; }

        public Deck()
        {
            Cards = new List<Card>();
            foreach (var suit in Suits)
            {
                foreach (var value in Values)
                {
                    Cards.Add(new Card { Suit = suit, Value = value });
                }
            }
            Shuffle();
        }

        public void Shuffle()
        {
            Random rng = new Random();
            for (int i = Cards.Count - 1; i > 0; i--)
            {
                int j = rng.Next(i + 1);
                Card temp = Cards[i];
                Cards[i] = Cards[j];
                Cards[j] = temp;
            }
        }

        public Card Deal()
        {
            Card card = Cards[0];
            Cards.RemoveAt(0);
            return card;
        }
    }
}
