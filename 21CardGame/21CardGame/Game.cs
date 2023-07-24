using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21CardGame
{
    class Game
    {
        public List<string> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }

        public void ListPlayers()
        {
            Console.WriteLine("Listing players in {0}", Name);
            foreach (string player in Players)
            {
                Console.WriteLine(player);
            }
            Console.ReadLine();
        }

    }
}
