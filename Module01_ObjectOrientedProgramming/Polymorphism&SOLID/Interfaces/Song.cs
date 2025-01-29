namespace Interfaces
{
    public class Song : IPlayable
    {
        public string Title { get; set; }

        public void Play()
        {
            Console.WriteLine("Playing song...");
        }
    }
}
