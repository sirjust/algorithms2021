using System;
using System.Collections.Generic;
using System.Linq;

namespace Blackjack2021
{
    class Program
    {
        static void Main(string[] args)
        {
            //var deck = new Deck();
            //foreach(var card in deck.Cards)
            //{
            //    Console.WriteLine($"{card.Face} of {card.Suit}");
            //}
            //Console.WriteLine($"{deck.Cards.Count} cards total");

            //deck.ShuffleRemaining();
            //deck.ShuffleRemaining();
            //foreach (var card in deck.Cards)
            //{
            //    Console.WriteLine($"{card.Face} of {card.Suit}");
            //}
            //Console.WriteLine($"{deck.Cards.Count} cards total");

            Game game = new Game();
            Dealer dealer = new Dealer { Name = "George" };
            List<Player> players = new List<Player>
                { new Player { Name = "Max" },
                { new Player { Name = "Sarah" }
                } };
            game.StartGame(players, dealer);

            var maxCards = players.Where(x => x.Name == "Max").FirstOrDefault().Cards;
            Console.WriteLine($"Max has the following cards: {maxCards.FirstOrDefault().GetCardName()} and {maxCards.LastOrDefault().GetCardName()}");
        }
    }
}
