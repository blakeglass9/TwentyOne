using System;
using System.Collections.Generic;

namespace TwentyOne
{
    public class TwentyOneGame
    {
        public List<Player> Players { get; set; } = new List<Player>();
        private Deck deck;

        public void Play()
        {
            Console.WriteLine("Starting a game of 21...");
            deck = new Deck();

            foreach (Player player in Players)
            {
                // Deal initial cards to the player and dealer
                List<Card> playerHand = new List<Card> { deck.Deal(), deck.Deal() };
                List<Card> dealerHand = new List<Card> { deck.Deal(), deck.Deal() };

                Console.WriteLine($"{player.Name}, your cards are: {string.Join(", ", playerHand)}");
                Console.WriteLine($"Dealer's visible card: {dealerHand[0]}");

                bool playerTurn = true;
                while (playerTurn)
                {
                    Console.WriteLine("Hit or stay?");
                    string response = Console.ReadLine().ToLower();

                    if (response == "hit")
                    {
                        Card newCard = deck.Deal();
                        playerHand.Add(newCard);
                        Console.WriteLine($"You drew a {newCard}");
                        // Add logic here to check if the player is over 21 (bust)
                    }
                    else if (response == "stay")
                    {
                        playerTurn = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Please type 'hit' or 'stay'.");
                    }
                }

                // After player finishes, reveal dealer's hand and add game logic
                Console.WriteLine($"Dealer's final hand: {string.Join(", ", dealerHand)}");

                // Add further logic for determining the winner, etc.
            }
            Console.WriteLine("Game has ended.");
        }
    }
}
