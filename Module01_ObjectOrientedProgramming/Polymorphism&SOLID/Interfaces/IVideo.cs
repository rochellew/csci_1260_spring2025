namespace Interfaces
{
    internal interface IVideo
    {
        string Rating { get; }
        int Runtime { get; }

        string GetDescription();
    }
}
