using System.Text.Json;

List<Card> cards = new List<Card>
{
    new Card{Face = Face.Ace, Suit = Suit.Hearts},
    new Card{Face = Face.Ace, Suit = Suit.Diamonds},
    new Card{Face = Face.Ace, Suit = Suit.Clubs},
    new Card{Face = Face.Ace, Suit = Suit.Spades},
    new Card{Face = Face.King, Suit = Suit.Diamonds},
    new Card{Face = Face.Three, Suit = Suit.Clubs},
    new Card{Face = Face.Five, Suit = Suit.Clubs},
    new Card{Face = Face.Queen, Suit = Suit.Hearts},
    new Card{Face = Face.Two, Suit = Suit.Spades},
    new Card{Face = Face.Two, Suit = Suit.Hearts}
};

foreach(var c in cards) System.Console.WriteLine(c);

System.Console.WriteLine("\nSorting...\n");
cards.Sort();
foreach(var c in cards) System.Console.WriteLine(c);


var genDeck = new List<Card>();

foreach(var suit in typeof(Suit).GetEnumValues())
{
    foreach(var face in typeof(Face).GetEnumValues())
    {
        genDeck.Add(new Card{Face = (Face)face, Suit = (Suit)suit});
    }
}

System.Console.WriteLine("\nGenerated Deck");
foreach(var c in genDeck) System.Console.WriteLine(c);

// IEquatable lets us compare equality between two objects
// via the `Equals` method (see Card.cs)
Card c1 = new Card{Face = Face.Ace, Suit = Suit.Spades};
Card c2 = new Card{Face = Face.Ace, Suit = Suit.Spades};
if(c1.Equals(c2)) System.Console.WriteLine("\nSAME!");

// '@' means treat everything in string as literal -- no special characters
// notice the numbers for Suit and Face -- these are required by serializer
// and will be converted to the Face and Suit values by the Deserialize method.
string json = @"{""Suit"": 1,""Face"": 11}";
System.Console.WriteLine(json);

// deserialize: JSON --> Object
Card? deserializedCard = JsonSerializer.Deserialize<Card>(json);
System.Console.WriteLine($"{deserializedCard}\n");

// serialize: Object --> JSON
// Note: the Enums for "Face" and "Suit" will be treated as numbers by serializer
string serializedDeck = JsonSerializer.Serialize<List<Card>>(genDeck);
File.WriteAllText("./deck.json", serializedDeck);

