using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21CardGame
{
    public class Player
    {
        public Player(string name = "Jane Doe", int bank = 0)
        {
            Name = name;
            Balance = bank;
        }

        public List<Card> Hand { get; set; }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public bool Stay { get; set; }

        public static Game operator+ (Game game, Player player)
        {
            game.Players.Add(player);
            return game;
        }

        public static Game operator- (Game game, Player player)
        {
            game.Players.Remove(player);
            return game;
        }

        public bool Bet(int amount)
        {
            if (Balance - amount < 0)
            {
                Console.WriteLine("You don't have enough to bet that much!");
                return false;
            } else
            {
                Console.WriteLine("You bet ${0}", amount);
                Balance -= amount;
                return true;
            }
        }
    }
}
