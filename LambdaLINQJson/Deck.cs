using System.Text.Json;

public class Deck
{
    public List<Card>? cards {get;set;}
    public Deck()
    {
        string json = File.ReadAllText("./deck.json");
        cards = JsonSerializer.Deserialize<List<Card>>(json);
    }
}
