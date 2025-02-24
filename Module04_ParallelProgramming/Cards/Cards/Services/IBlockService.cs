using Cards.Models;

namespace Cards.Services
{
    public interface IBlockService
    {
        Task<List<Block>> GetBlocksAsync();
    }
}
