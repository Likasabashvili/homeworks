namespace delegates;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 2, 5, 8, 3, 10, 7 };
        
        Console.WriteLine("Where:");
        var filtered = numbers.FilterCollection(x => x > 5);

        foreach (var item in filtered)
        {
            Console.WriteLine(item);
        }
        
        Console.WriteLine("FirstOrDefault:");
        Console.WriteLine(numbers.FirstOrDefault(x => x > 5));
        
        
        Console.WriteLine("Any:");
        Console.WriteLine(numbers.Any(x => x > 9));
        
        Console.WriteLine("All:");
        Console.WriteLine(numbers.All(x => x > 0));
        
        Console.WriteLine("Count:");
        Console.WriteLine(numbers.Count(x => x > 5));
    
    }
}