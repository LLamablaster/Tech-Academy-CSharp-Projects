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
            Deck deck = new Deck();
            deck.debug();
            deck.shuffle();
            deck.shuffle(3);
            deck.debug();
        }


    }
}
