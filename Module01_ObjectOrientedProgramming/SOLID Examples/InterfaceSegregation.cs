// Interface Segregation Principle (ISP)
// Classes should not be forced to implement interfaces that they do not use.

// ISP violation
// Notice the class implements an interface with unneccesary methods
interface IWorker {
    void Work();
    void Eat();
}

class Robot : IWorker {
    public void Work() {
        Console.WriteLine("Working...");
    }

    public void Eat() {
        throw new NotImplementedException("Robots don't eat...");
    }
}

// ISP Adherance
// Fix: split the interface into smaller, more focused interfaces

interface Worker {
    void Work();
}

interface IHumanWorker : IWorker {
    void Eat();
}

class Robot : IWorker {
    public void Work() {
        Console.WriteLine("Working...");
    }
}

class Human : IHumanWorker {
    public void Work() {
        Console.WriteLine("Working...");
    }

    public void Eat() {
        Console.WriteLine("Eating...")
    }
}