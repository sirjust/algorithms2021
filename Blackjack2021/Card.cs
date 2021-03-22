namespace Blackjack2021
{
    public class Card
    {
        public string Face { get; set; }
        public string Suit { get; set; }

        public string GetCardName()
        {
            return $"{Face} of {Suit}";
        }

        public Card() { }

        public Card(string face, string suit)
        {
            Face = face;
            Suit = suit;
        }
    }
}
