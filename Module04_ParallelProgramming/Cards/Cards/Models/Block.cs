using System.Text.Json.Serialization;

namespace Cards.Models
{
    public class Block
    {
        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("description")]
        public string Description { get; set; } = string.Empty;
    }
}
