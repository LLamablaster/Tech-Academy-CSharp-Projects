using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21CardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Game_TwentyOne game = new Game_TwentyOne();
            game.Players = new List<string> { "Matt", "Bill", "Jean" };
            game.ListPlayers();
            game.Play();
            //Deck deck = new Deck();
            //deck.debug();
            //deck.shuffle();
            //deck.shuffle(3);
            //deck.debug();
        }


    }
}
