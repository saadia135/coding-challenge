using System;

class Program
{
    static void Main()
    {
        Random randomGenerator = new Random();

        int randomNumber1 = randomGenerator.Next();
        int randomNumber2 = randomGenerator.Next(201); // Random number between 0 and 200
        int randomNumber3 = randomGenerator.Next(100, 201); // Random number between 100 and 200

        Console.WriteLine($"Generated number 1: {randomNumber1}");
        Console.WriteLine($"Generated number 2: {randomNumber2}");
        Console.WriteLine($"Generated number 3: {randomNumber3}");

        double randomDouble = randomGenerator.NextDouble(); // Random double between 0.0 and 1.0
        Console.WriteLine($"Generated double: {randomDouble:F4}"); // Four decimal places

        int[] randomArray = new int[5];
        for (int i = 0; i < randomArray.Length; i++)
        {
            randomArray[i] = randomGenerator.Next(1, 51); // Random number between 1 and 50
        }
        Console.WriteLine("Generated array: " + string.Join(", ", randomArray));
    }
}

