using System;

class Program
{
    static void Main()
    {
        Random dice = new Random();
        int roll1 = dice.Next(1, 7);
        int roll2 = dice.Next(1, 7);
        int roll3 = dice.Next(1, 7);
        int total = roll1 + roll2 + roll3;

        Console.WriteLine($"Dice rolls: {roll1}, {roll2}, {roll3}");
        Console.WriteLine($"Initial total: {total}");

        if (roll1 == roll2 && roll2 == roll3)
        {
            Console.WriteLine("You rolled triples! +10 bonus to total!");
            total += 10;
        }
        else if (roll1 == roll2 || roll2 == roll3 || roll1 == roll3)
        {
            Console.WriteLine("You rolled doubles! +5 bonus to total!");
            total += 5;
        }

        // Additional bonus for specific conditions
        if (total % 2 == 0)
        {
            Console.WriteLine("Total is even! +3 bonus to total!");
            total += 3;
        }
        else
        {
            Console.WriteLine("Total is odd! +1 bonus to total!");
            total += 1;
        }

        if (total >= 18)
        {
            Console.WriteLine("You win with a high score!");
        }
        else if (total >= 12)
        {
            Console.WriteLine("You win!");
        }
        else
        {
            Console.WriteLine("Sorry, you lose.");
        }

        Console.WriteLine($"Final total: {total}");
    }
}

