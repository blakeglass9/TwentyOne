using System;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Grand Hotel and Casino. Let's start by telling me your name.");
            string playerName = Console.ReadLine();

            Console.WriteLine("And how much money did you bring today?");
            int bank = int.Parse(Console.ReadLine());

            Player player = new Player() { Name = playerName, Balance = bank };
            TwentyOneGame game = new TwentyOneGame();
            game.Players.Add(player);

            game.Play();
            Console.ReadLine();
        }
    }
}
