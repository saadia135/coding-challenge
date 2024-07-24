using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 10, 20, 30, 40 };
        
        Console.WriteLine("Initial state of the array:");
        PrintArray(numbers);

        // Clear elements from index 1 to index 2 (inclusive) in the array
        Array.Clear(numbers, 1, 2);

        Console.WriteLine("\nState of the array after clearing:");
        PrintArray(numbers);
    }

    static void PrintArray(int[] array)
    {
        foreach (var item in array)
        {
            // Parenthesize the conditional expression to avoid interpolation issues
            Console.WriteLine($"-- {(item == 0 ? "N/A" : item.ToString())}");
        }
    }
}
