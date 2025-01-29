namespace Interfaces
{
    // anything that implements this interface MUST MUST MUST MUST MUST have ALL properties and methods implemented. 
    internal interface IPlayable
    {
        string Title { get; }

        void Play();
    }
}
