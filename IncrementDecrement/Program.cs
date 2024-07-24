using System;

class Program
{
    static void Main()
    {
        int number = 5;
        number = number + 2;
        Console.WriteLine("First Increment by 2: " + number);
        
        number += 3;
        Console.WriteLine("Second Increment by 3: " + number);
        
        number++;
        Console.WriteLine("Third Increment by 1: " + number);
        
        number = number - 2;
        Console.WriteLine("First Decrement by 2: " + number);
        
        number -= 3;
        Console.WriteLine("Second Decrement by 3: " + number);
        
        number--;
        Console.WriteLine("Third Decrement by 1: " + number);
    }
}

