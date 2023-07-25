using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21CardGame
{
    public abstract class Game
    {
        public Game()
        {
            Players = new List<Player> { };
        }

        public List<Player> Players { get; set; }
        public string Name { get; set; }
        public Dealer Dealer { get; set; }
        public Dictionary<Player, int> Bets { get; set; }

        public abstract void Play();
        public virtual void ListPlayers()
        {
            Console.WriteLine("Listing players in {0}", Name);
            foreach (Player player in Players)
            {
                Console.WriteLine(player.Name);
            }
            Console.ReadLine();
        }

    }
}
