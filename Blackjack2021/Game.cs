using System.Collections.Generic;

namespace Blackjack2021
{
    public class Game
    {
        public List<Player> Players { get; set; }
        public Dealer Dealer { get; set; }

        public Deck Deck { get; set; }
        public Game()
        {

        }

        public void StartGame(List<Player> players, Dealer dealer)
        {
            Players = players;
            Dealer = dealer;
            Deck = new Deck();
            Deck.ShuffleRemaining();
            Deck.ShuffleRemaining();
            dealer.Cards.Add(Deck.DrawCard());
            dealer.Cards.Add(Deck.DrawCard());
            foreach(Player player in players)
            {
                player.Cards.Add(Deck.DrawCard());
                player.Cards.Add(Deck.DrawCard());
            }
        }
    }
}
