using homework2.Models;

namespace homework2;

class Program
{
    static void Main(string[] args)
    {
        Temperature t1 = new Temperature(25, "C");
        Temperature t2 = new Temperature(10, "F");

        Console.WriteLine("t1=" + t1);
        Console.WriteLine("t2=" + t2);

        Console.WriteLine("jami="  + (t1 + t2));
        Console.WriteLine("sxvaoba="+ (t1-t2));
        Console.WriteLine("gamravleba="+ (t1 * 2));
        Console.WriteLine("gamravleba="+ (t2 * 2));
        Console.WriteLine("gayofa="+ (t1 / 2));
        Console.WriteLine("gayofa="+ (t2 / 2));
        Console.WriteLine("nashti="+(t1 % 3));
        Console.WriteLine("nashti="+(t2 % 3));
        Console.WriteLine("t1 == t2: " + (t1 == t2));
        Console.WriteLine("t1 != t2: " + (t1 != t2));
        Console.WriteLine("t1 > t2: " + (t1 > t2));
        Console.WriteLine("t1 < t2: " + (t1 < t2));
        Console.WriteLine("t1 >= t2: " + (t1 >= t2));
        Console.WriteLine("t1 <= t2: " + (t1 <= t2));
        
    }
}