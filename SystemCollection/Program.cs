using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Initialize a list of numeric strings
        List<string> numbers = new List<string> { "10", "5", "20", "15" };
        
        Console.WriteLine("Sorted numerically...");
        // Convert the list to integers, sort them, then convert back to strings
        List<string> sortedNumbers = numbers
            .Select(num => int.Parse(num))
            .OrderBy(num => num)
            .Select(num => num.ToString())
            .ToList();

        foreach (string number in sortedNumbers)
        {
            Console.WriteLine($"--{number}");
        }

        Console.WriteLine("Reversed...");
        // Reverse the list
        sortedNumbers.Reverse();
        foreach (string number in sortedNumbers)
        {
            Console.WriteLine($"--{number}");
        }
    }
}

