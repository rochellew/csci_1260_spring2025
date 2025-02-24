using Cards.Models;
namespace Cards.Services
{
	public class CardDeckService :ICardDeckService
	{
		private List<Card>? _deck;
		private Random _rand = new Random();

		public CardDeckService()
		{
			InitializeDeck();
		}

		private void InitializeDeck()
		{
			_deck = new List<Card>();
			foreach(Suit suit in Enum.GetValues(typeof(Suit)))
			{
				foreach(Face face in Enum.GetValues(typeof(Face)))
				{ 
					_deck.Add(new Card { Suit  = suit, Face = face });
				}
			}
			ShuffleDeck();
		}

		private void ShuffleDeck()
		{
			_deck = _deck.OrderBy(c => _rand.Next()).ToList();
		}

		public async Task<Card?> DealCardAsync()
		{
			if (_deck.Count == 0)
				return null;

			await Task.Delay(500);
			Card dealtCard = _deck[0];
			_deck.RemoveAt(0);
			return dealtCard; 
		}
	}
}
