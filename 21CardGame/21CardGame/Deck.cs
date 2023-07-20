using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21CardGame
{
    class Deck
    {
        public Deck()
        {
            List<string> suits = new List<string> { "Hearts", "Diamonds", "Spades", "Clubs" };
            List<string> faces = new List<string>
            {
            "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", 
            "Eight", "Nine", "Ten", "Jack", "Queen", "King"
            };

            Cards = new List<Card>();

            foreach (string suit in suits)
            {
                foreach (string face in faces)
                {
                    Cards.Add(new Card(suit, face));
                }
            }

            
        }

        public List<Card> Cards { get; set; }

        public void debug()
        {
            foreach (Card card in Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine("Found " + Cards.Count + " total cards.");
            Console.ReadLine();
        }

        public void shuffle(int times = 1)
        {
            for (int i = 0; i < times; i++)
            {
                var result = new List<Card>();
                Random random = new Random();

                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, Cards.Count);
                    result.Add(Cards[randomIndex]);
                    Cards.RemoveAt(randomIndex);
                }

                Cards = result;
            }
        }
        
    }
}
