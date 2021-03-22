using System.Collections.Generic;

namespace Blackjack2021
{
    public class Dealer
    {
        public string Name { get; set; }
        public List<Card> Cards { get; set; }
        public Dealer()
        {
            Cards = new List<Card>();
        }
    }
}