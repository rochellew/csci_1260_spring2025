public class BlathersService : IBlathersService
{
    private string[] facts = { "Tarantulas are actually quite shy!", "Oarfish can grow up to 26 feet!", "Scorpions grow under UV light!" };
    private Random rnd = new Random();

    public string GetRandomFact() => facts[rnd.Next(facts.Length)];
}