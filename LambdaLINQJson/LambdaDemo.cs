//Lambda expressions = anonymous function
//(parameters) => expression
public class LambdaDemo
{
    static void LambdaFunctionality()
    {
        List<int> numbers = new List<int>
        {
            1,2,3,4,5,6,7,8,9
        };

        List<int> evens = numbers.Where(n => n % 2 == 0).ToList();


        Func<int,int> square = x => x * x;
        int result = square(4);

        // LINQ - Language Integrated Query 
        // we can query collections (data structures)

        // 1. Method syntax
        var names = new List<string>{"Zee", "Nathan", "Sydney", "Isaac"};

        // i only want names that contain 'a'
        var filtered = names.Where(n => n.Contains('a')).ToList();
        foreach(var n in filtered) System.Console.WriteLine(n);

        // 2. Query syntax
        var filtered2 = from n in names 
                        where n.Contains('a') 
                        select n;
    }
}

