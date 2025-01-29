public abstract class Shape
{
    public string Color { get; set; }

    // "Anything that inherits from shape can override this empty method"
    public abstract double GetArea();
}