namespace AbstractClasses
{
    public class Square : Shape
    {
        public int Length { get; set; }
        public int Height { get; set; }

        public override double GetArea()
        {
            return Length * Height;
        }
    }
}
