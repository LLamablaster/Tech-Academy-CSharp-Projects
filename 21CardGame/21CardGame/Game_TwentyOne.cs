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
            //initialize dealer
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
            Dealer.Deck.shuffle(3);
            //take bets
            Dictionary<Player, int> Bets = new Dictionary<Player, int>();
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
            //deal 2 cards to everyone
            Console.WriteLine("Dealing...");
            for (int i = 0; i < 2; i++)
            {
                //deal to players
                foreach (Player player in Players)
                {
                    Console.Write("{0}: ", player.Name);
                    Dealer.deal(player.Hand);
                    //on second card check for blackjack
                    if (i == 1)
                    {
                        if (_21rules.IsBlackjack(player.Hand))
                        {
                            Console.WriteLine("Blackjack!");
                            Console.WriteLine("{0} wins {1}", player.Name, Bets[player] * 2.5);
                            player.Balance += Convert.ToInt32(Bets[player] * 2.5);
                            Bets.Remove(player);
                            return;
                        }
                    }
                }
            }
            //deal to dealer
            Console.Write("Dealer: ");
            Dealer.deal(Dealer.Hand);
            Console.Write("Dealer: ");
            Dealer.deal(Dealer.Hand);
            //check for dealer blackjack
            if (_21rules.IsBlackjack(Dealer.Hand))
            {
                Console.WriteLine("Dealer has blackjack!");
                Console.WriteLine("Everyone loses...");
                foreach (KeyValuePair<Player, int> bet in Bets)
                {
                    Dealer.Balance += bet.Value;
                    Bets.Remove(bet.Key);
                }
                return;
            }
            //ask for hits
            foreach (Player player in Players)
            {
                while (!player.Stay)
                {
                    Console.WriteLine("You are holding: ");
                    foreach (Card card in player.Hand)
                    {
                        Console.Write("{0}, ", card.ToString());
                    }
                    Console.WriteLine("\n\nYou are sitting at {0}. Hit or stay?", _21rules.HandValue(player.Hand));
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "stay")
                    {
                        player.Stay = true;
                        Console.WriteLine("{0} stays with {1}.", player.Name, _21rules.HandValue(player.Hand));
                        break;
                    }
                    else if (answer == "hit")
                    {
                        Dealer.deal(player.Hand);
                    }
                    //check for blackjack
                    if (_21rules.IsBlackjack(player.Hand))
                    {
                        Console.WriteLine("Blackjack!");
                        Console.WriteLine("{0} wins {1}", player.Name, Bets[player] * 2.5);
                        player.Balance += Convert.ToInt32(Bets[player] * 2.5);
                        Bets.Remove(player);
                        return;
                    }
                    //check for busts
                    bool busted = _21rules.HandValue(player.Hand) > 21;
                    if (busted)
                    {
                        Dealer.Balance += Bets[player];
                        Console.WriteLine("You went bust, {0}! You lost {1}. You have {2} remaining.",
                            player.Name, Bets[player], player.Balance);
                        Console.WriteLine("Your balance is {0}. Do you want to keep playing?", player.Balance);
                        string response = Console.ReadLine().ToLower();
                        if (answer == "yes" || answer == "yeah" || answer == "y")
                        {
                            player.IsActive = true;
                            return;
                        } else { 
                            player.IsActive = false;
                            return;
                        }
                    }
                }
            }
            Dealer.Busted = _21rules.HandValue(Dealer.Hand) > 21;
            while (!_21rules.DealerStays(Dealer.Hand) && Dealer.Busted == false)
            {
                Dealer.deal(Dealer.Hand);
                Dealer.Busted = _21rules.HandValue(Dealer.Hand) > 21;
            }
            if (Dealer.Busted)
            {
                Console.WriteLine("Dealer busts! Everyone wins.");
                foreach (KeyValuePair<Player, int> bet in Bets.ToList())
                {
                    bet.Key.Balance += Convert.ToInt32(bet.Value*2.5);
                    Console.WriteLine("{0} won {1}.", bet.Key.Name, Convert.ToInt32(bet.Value * 2));
                    Dealer.Balance -= bet.Value;
                    Bets.Remove(bet.Key);
                    Console.WriteLine("Your balance is {0}. Do you want to keep playing?", bet.Key.Balance);
                    string response = Console.ReadLine().ToLower();
                    if (response == "yes" || response == "yeah" || response == "y")
                    {
                        bet.Key.IsActive = true;
                        return;
                    }
                    else
                    {
                        bet.Key.IsActive = false;
                        return;
                    }
                }
                return;

            } else if (Dealer.Stay)
            {
                Console.WriteLine("Dealer stays with {0}.", _21rules.HandValue(Dealer.Hand));
            }
            foreach (Player player in Players)
            {
                bool? playerWon = _21rules.CompareHands(player.Hand, Dealer.Hand);
                if (playerWon == null)
                {
                    Console.WriteLine("{0} push! No winner.", player.Name);
                } else if (playerWon == true)
                {
                    Console.WriteLine("{0} wins! They got {1}.", player.Name, Bets[player]);
                    player.Balance += Bets[player] * 2;
                    Dealer.Balance -= Bets[player];
                } else
                {
                    Console.WriteLine("Dealer beats {0}! They lost their {1}.", player.Name, Bets[player]);
                    Dealer.Balance += Bets[player];
                }

                Console.WriteLine("Your balance is {0}. Would you like to play another hand?", player.Balance);
                string answer3 = Console.ReadLine().ToLower();
                if (answer3 == "yes" || answer3 == "yeah" || answer3 == "y")
                {
                    player.IsActive = true;
                } else { player.IsActive = false; }
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
