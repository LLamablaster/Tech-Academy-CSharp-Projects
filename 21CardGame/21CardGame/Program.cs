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
            //Game game = new Game_TwentyOne();
            //Player player = new Player();
            //game = game + player;
            //game.ListPlayers();
            //game.Players = new List<Player> { new Player(), new Player(), new Player() };
            //game.ListPlayers();
            //game.Play();
            Deck deck = new Deck();
            deck.list();
            deck.shuffle();
            deck.shuffle(3);
            deck.list();
        }


    }
}
