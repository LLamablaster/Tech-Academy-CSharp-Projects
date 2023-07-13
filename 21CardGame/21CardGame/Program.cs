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
            deck = shuffle(deck);
            deck.debug();
        }

        public static Deck shuffle(Deck deck)
        {
            var result = new List<Card>();
            Random random = new Random();

            while (deck.Cards.Count > 0)
            {
                int randomIndex = random.Next(0, deck.Cards.Count);
                result.Add(deck.Cards[randomIndex]);
                deck.Cards.RemoveAt(randomIndex);
            }

            deck.Cards = result;
            return deck;
        }
    }
}
