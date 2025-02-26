using MinecraftBlocks.Models;
using System.Text.Json;

namespace MinecraftBlocks.Services
{
    public class BlockService : IBlockService
    {
        public async Task<List<Block>> GetBlocksAsync()
        {
            // magic! 
            string url = "https://minecraft-api.vercel.app/api/blocks";

            HttpClient client = new HttpClient();
            var response = await client.GetFromJsonAsync<JsonElement>(url);

            File.WriteAllText("blocks.json", response.ToString());

            List<Block>? blocks = response.Deserialize<List<Block>>();
            return blocks!;
        }

        public List<Block> GetBlocks()
        {
            string json = File.ReadAllText("blocks.json");
            List<Block>? blocks = JsonSerializer.Deserialize<List<Block>>(json);
            return blocks!;
        }
    }
}
