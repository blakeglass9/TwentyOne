using System.Collections.Generic;

namespace TwentyOne
{
    public static class TwentyOneRules
    {
        public static int CalculateHandValue(List<Card> Hand)
        {
            // Basic rules to calculate hand value for Blackjack
            int total = 0;
            foreach (Card card in Hand)
            {
                total += CardValue(card);
            }
            return total;
        }

        private static int CardValue(Card card)
        {
            switch (card.Value)
            {
                case "Two": return 2;
                case "Three": return 3;
                case "Four": return 4;
                case "Five": return 5;
                case "Six": return 6;
                case "Seven": return 7;
                case "Eight": return 8;
                case "Nine": return 9;
                case "Ten": case "Jack": case "Queen": case "King": return 10;
                case "Ace": return 11; // Simplified handling; consider Ace as 1 or 11
                default: return 0;
            }
        }
    }
}
