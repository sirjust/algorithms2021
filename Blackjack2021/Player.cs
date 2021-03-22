using System.Collections.Generic;

namespace Blackjack2021
{
    public class Player
    {
        public string Name { get; set; }
        public List<Card> Cards { get; set; }
        public decimal CurrentBet { get; set; }
        public decimal TotalBet { get; set; }

        public Player()
        {
            Cards = new List<Card>();
        }
    }
}