using System;

class Program
{
    static void Main()
    {
        int number = 10;
        number++;
        Console.WriteLine("First Increment: " + number);
        Console.WriteLine("Second Increment and Print: " + number++);
        Console.WriteLine("Third Print after Increment: " + number);
        Console.WriteLine("Fourth Increment and Print: " + (++number));

        int anotherNumber = 5;
        ++anotherNumber;
        anotherNumber++;
        Console.WriteLine("First Increment: " + anotherNumber);
    }
}

