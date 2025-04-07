public class Card : IComparable<Card>, IEquatable<Card>
{
    public Face Face {get;set;}
    public Suit Suit {get;set;}


    /// <summary>
    ///     Implementation required by IComparable
    /// </summary>
    /// <param name="cardToCompareTo"></param>
    /// <returns>
    /// '0' if objects are the same
    /// '1' if the current object is "greater" 
    /// '-1' if the current object is "less"
    ///</returns>
    public int CompareTo(Card? cardToCompareTo)
    {   
        // compare the two cards
        if(this.Suit == cardToCompareTo!.Suit)
        {
            if(this.Face == cardToCompareTo.Face)
                return 0;
            if(this.Face < cardToCompareTo.Face)
                return -1;
            else if(this.Face > cardToCompareTo.Face)
                return 1;
        }
        else if(this.Suit < cardToCompareTo.Suit)
            return -1;
        else if(this.Suit > cardToCompareTo.Suit)
            return 1;

        return 0;
    }

    public bool Equals(Card? cardToCompareTo) => 
        this.Face == cardToCompareTo!.Face && 
        this.Suit == cardToCompareTo.Suit;
    
    public override string ToString()
    {
        return $"{Face} of {Suit}";
    }
}