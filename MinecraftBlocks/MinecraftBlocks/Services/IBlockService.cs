using MinecraftBlocks.Models;

namespace MinecraftBlocks.Services
{
    public interface IBlockService
    {
        Task<List<Block>> GetBlocksAsync();
        List<Block> GetBlocks();
    }
}
