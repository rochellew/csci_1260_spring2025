using System.Text.Json.Serialization;

namespace MinecraftBlocks.Models
{
    public class Block
    {
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("description")]
        public string Description { get; set; } = string.Empty;

        [JsonPropertyName("image")]
        public string Image { get; set; } = string.Empty;

        [JsonPropertyName("transparent")]
        public bool Transparent { get; set;  }
    }
}
