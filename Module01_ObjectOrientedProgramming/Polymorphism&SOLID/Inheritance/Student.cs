namespace Inheritance
{
    public class Student : Person
    {
        public string Major { get; set; } = "";
        public double GPA { get; set; }
        public int HoursCompleted { get; set; }

        // constructor 
        // we need to call the 'base' constructor
        public Student (string major, double gpa, int hoursCompleted, string name, DateOnly birthday) : base(name, birthday)
        {
            Major = major;
            GPA = gpa;
            HoursCompleted = hoursCompleted;
        }

        public override string MyMethod()
        {
            return "What's Up";
        }
    }
}
