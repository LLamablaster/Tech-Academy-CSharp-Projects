using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21CardGame
{
    class Card
    {
        public Card(string suit, string face)
        {
            Suit = suit;
            Face = face;
        }
        public string Suit { get; set; }
        public string Face { get; set; }
    }
}
