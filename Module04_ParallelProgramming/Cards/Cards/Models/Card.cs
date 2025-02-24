namespace Cards.Models
{
	public enum Face
	{
		Two = 2, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King, Ace
	}

	public enum Suit
	{
		Hearts, Diamonds, Clubs, Spades
	}

	public class Card
	{
		public Suit Suit { get; set; }
		public Face Face { get; set;  }

		public override string ToString() => $"{Face} of {Suit}";
	}
}
