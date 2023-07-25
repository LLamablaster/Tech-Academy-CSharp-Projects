using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21CardGame
{
    public class Game_TwentyOne : Game, IWalkAway
    {
        public Dealer_TwentyOne Dealer { get; set; }
        public override void Play()
        {
            Dealer = new Dealer_TwentyOne();
            foreach (Player player in Players)
            {
                player.Hand = new List<Card>();
                player.Stay = false;
            }
            Dealer.Hand = new List<Card>();
            Dealer.Stay = false;
            Dealer.Busted = false;
            Dealer.Deck = new Deck();
            Console.WriteLine("Place your bet.");
            
            foreach (Player player in Players)
            {
                int bet = Convert.ToInt32(Console.ReadLine());
                bool successfullyBet = player.Bet(bet);
                if (!successfullyBet)
                {
                    return;
                }
                Bets[player] = bet;
            }
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Dealing...");
                foreach (Player player in Players)
                {
                    Console.Write("{0}: ", player.Name);
                    Dealer.deal(player.Hand);
                    if (i == 1)
                    {
                        
                    }
                }
            }
        }

        public override void ListPlayers()
        {
            Console.WriteLine("Listing 21 players");
            base.ListPlayers();
        }

        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
