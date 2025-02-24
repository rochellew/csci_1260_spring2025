using Cards.Models;
using System.Net.Http.Json;
using System.Text.Json;

namespace Cards.Services
{
    public class BlockService : IBlockService
    {
        public async Task<List<Block>> GetBlocksAsync()
        {
            var URL = "https://minecraft-api.vercel.app/api/blocks/";

            HttpClient client = new HttpClient();
            var response = await client.GetFromJsonAsync<JsonElement>(URL);

            List<Block>? blocks = response.Deserialize<List<Block>>();

            return blocks;
        }
    }
}
