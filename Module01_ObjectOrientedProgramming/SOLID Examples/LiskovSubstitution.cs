// Liskov Substitution Principle

// Subtypes should be substitutable for their base types without altering the correctness of the program.

// LSP violation
class Bird {
    // remember virtual methods CAN be overridden
    public virtual void Fly() {
        Console.WriteLine("Flying...");
    }
}

class Penguin : Bird {
    public override void Fly() {
        throw new NotImplementedException("Penguins can't fly!");
    }
}

// LSP adherance
// fix: refactor the hierarchy for separate behaviors

// remember abstract classes are designed solely to be inherited from
abstract class Bird {
    public abstract void Move();
}

class FlyingBird : Bird {
    public override void Move(){
        Console.WriteLine("Flying...")
    }
}

class NonFlyingBird : Bird {
    public override void Move(){
        Console.WriteLine("Walking...")
    }
} 

class Penguin : NonFlyingBird {}