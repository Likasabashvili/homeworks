using generic.Models;

namespace generic;

class Program
{
    static void Main(string[] args)
    {
        ArrayHelper<int> arrayHelper = new();
        int[] nums = { 10, 20, 30, 40, 50 };

        Console.WriteLine($"reversed array:{arrayHelper.PrintReverse(nums)}");
        Console.WriteLine($"array first element:{arrayHelper.GetFirstElement(nums)}");
        Console.WriteLine($"array last element{arrayHelper.GetLastElement(nums)}");
        Console.WriteLine($"if array contains something{arrayHelper.ContainsElement(nums, 20)}");
        Console.WriteLine($"array elements count:{arrayHelper.CountElements(nums)} ");
        Console.WriteLine($"find index{arrayHelper.FindIndex(nums, 40)}");
        
    }
}