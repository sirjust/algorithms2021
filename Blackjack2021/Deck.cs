using System;
using System.Collections.Generic;
using System.Linq;

namespace Blackjack2021
{
    public class Deck
    {
        public List<Card> Cards { get; set; }
        public Deck()
        {
            Cards = new List<Card>();
            foreach(Face face in Enum.GetValues(typeof(Face)))
            {
                foreach(Suit suit in Enum.GetValues(typeof(Suit))){
                    Cards.Add(new Card(face.ToString(), suit.ToString()));
                }
            }
        }
        public Card DrawCard()
        {
            var card = Cards.FirstOrDefault();
            Cards.RemoveAt(0);
            return card;
        }

        public void ShuffleRemaining()
        {
            for(int i = 0; i < Cards.Count; i++)
            {
                Random random = new Random();
                Card cardToShuffle = Cards[i];
                Cards.RemoveAt(i);
                Cards.Insert(random.Next(0, Cards.Count), cardToShuffle);  
            }
            Console.WriteLine("Deck shuffled");
        }
    }
}
