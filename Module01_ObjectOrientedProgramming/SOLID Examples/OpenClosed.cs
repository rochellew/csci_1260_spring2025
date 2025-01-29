// Open-Closed Principle: classes should be open for extension but closed for modificiation


// OCP Violation
class DiscountCalculator
{
    public double CalculateDiscount(string customerType, double amount)
    {
        if(customerType == "Regular") 
        {
            return amount * 0.1;
        }
        else if (customerType == "VIP")
        {
            return amount * 0.2;
        }
        else
        {
            return 0; // no discount for other types
        }
    }
}

// OCP Adherence
// refactor to use polymorphism so that you may extend the class without modifying existing code
interface IDiscount {
    double ApplyDiscount(double amount);
}

class RegularDiscount : IDiscount {
    public double ApplyDiscount(double amount) {
        return amount * 0.1;
    }
}

class VIPDiscount : IDiscount {
    public double ApplyDiscount(double amount) {
        return amount * 0.2;
    }
}

class DiscountCalculator {
    public double CalculateDiscount(IDiscount discount, double amount) {
        return discount.ApplyDiscount(amount);
    }
}