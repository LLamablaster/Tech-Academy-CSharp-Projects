using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21CardGame
{
    public class Dealer
    {
        public Dealer(string name = "John Doe", int balance = 1000 )
        {
            Name = name;
            Balance = balance;
            Deck = new Deck();
        }

        public Dealer(Deck deck, string name = "John Doe", int balance = 1000)
        {
            Name = name;
            Balance = balance;
            Deck = deck;
        }

        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        public void deal(List<Card> hand)
        {
            Card topcard = Deck.Cards.First();
            hand.Add(topcard);
            Console.WriteLine(topcard.ToString() + "\n");
            Deck.Cards.RemoveAt(0);
        }
    }
}
