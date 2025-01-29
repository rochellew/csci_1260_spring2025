namespace Interfaces
{
    internal class Movie : IPlayable, IVideo
    {
        public string Title { get; set; } // IPlayable
        public string Rating { get; set; } // IVideo
        public int Runtime { get; set;  } // IVideo

        public void Play()
        {
            Console.WriteLine("Playing movie...");
        }

        public string GetDescription()
        {
            return "some description";
        }
    }
}
