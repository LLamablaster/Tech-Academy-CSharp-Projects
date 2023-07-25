using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21CardGame
{
    public class _21rules
    {
        public static int HandValue(List<Card> hand)
        {
            int value = 0;
            int aces = 0;
            foreach (Card card in hand)
            {
                value += _FaceValues[card.Face];
                if (card.Face == Face.Ace)
                {
                    aces += 1;
                }
            }
            for (int i = 0; i<aces; i++)
            {
                if (value > 21)
                {
                    value -= 10;
                }
            }
            return value;
        }
        public static bool IsBlackjack(List<Card> hand)
        {
            return HandValue(hand)==21;
        }

        public static bool? CompareHands(List<Card> hand1, List<Card> hand2)
        {
            bool? hand1wins = _21rules.HandValue(hand1) > _21rules.HandValue(hand2);
            if (_21rules.HandValue(hand1) == _21rules.HandValue(hand2)) { hand1wins = null; }
            return hand1wins;
        }

        public static bool DealerStays(List<Card> hand)
        {
            int handscore = _21rules.HandValue(hand);
            if (handscore > 16 && handscore < 22)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public void Test()
        {
            Dealer_TwentyOne dealer = new Dealer_TwentyOne();
            dealer.Deck.shuffle();
            List<Card> hand = new List<Card>();
            dealer.deal(hand);
            dealer.deal(hand);
            Console.WriteLine("You got a {0} of {1} and a {2} of {3}",
                hand[0].Face, hand[0].Suit, hand[1].Face, hand[1].Suit);
            Console.WriteLine("Hand value is {0}", HandValue(hand));
            if (IsBlackjack(hand))
            {
                Console.WriteLine("Blackjack!");
            }
            Console.ReadLine();
        }

        private static Dictionary<Face, int> _FaceValues = new Dictionary<Face, int>()
        {
            [Face.Ace] = 11,
            [Face.Deuce] = 2,
            [Face.Three] = 3,
            [Face.Four] = 4,
            [Face.Five] = 5,
            [Face.Six] = 6,
            [Face.Seven] = 7,
            [Face.Eight] = 8,
            [Face.Nine] = 9,
            [Face.Ten] = 10,
            [Face.Jack] = 10,
            [Face.Queen] = 10,
            [Face.King] = 10,
        };
            

    }
}
