using Cards.Models;
namespace Cards.Services
{
	public interface ICardDeckService
	{
		Task<Card?> DealCardAsync();
	}
}
