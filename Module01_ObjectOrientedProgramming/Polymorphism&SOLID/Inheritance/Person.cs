
namespace Inheritance
{
    public class Person
    {
        // properties
        public string Name { get; set; }
        public DateOnly BirthDay { get; set; }

        // constructors
        public Person()
        {
            Name = "";
            BirthDay = new DateOnly();
        }

        public Person(string name, DateOnly birthday)
        {
            Name = name;
            BirthDay = birthday;
        }

        public override string ToString()
        {
            return $"{Name}, {BirthDay}";
        }

        public virtual string MyMethod()
        {
            return "Hey";
        }
    }
}
