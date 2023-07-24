using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21CardGame
{
    public class Deck
    {
        public Deck()
        {
            Cards = new List<Card>();
            for (int s = 0; s < 4; s++)
            {
                for (int f = 0; f < 13; f++)
                {
                    Cards.Add(new Card((Suit)s, (Face)f));
                }
            }

            
        }

        public List<Card> Cards { get; set; }

        public void list()
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
