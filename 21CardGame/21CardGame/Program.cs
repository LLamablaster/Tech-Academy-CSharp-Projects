using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _21CardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the casino. Let's start with your name.");
            string playerName = Console.ReadLine();

            Console.WriteLine("How much cash did you bring today?");
            int playerBank = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y")
            {
                Player player = new Player(playerName, playerBank);
                Game game = new Game_TwentyOne();
                game += player;
                player.IsActive = true;
                while (player.IsActive && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thanks for playing!");
            }
            Console.WriteLine("Don't loiter, deadbeat.");
            Console.ReadLine();

        }


    }
}
