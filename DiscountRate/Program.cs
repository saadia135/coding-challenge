using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int daysLeft = random.Next(15); // Generate a random number between 0 and 14
        int discountRate = 0;

        // Determine discount rate based on days left until expiration
        if (daysLeft == 0)
        {
            Console.WriteLine("Your subscription has expired!");
        }
        else if (daysLeft == 1)
        {
            discountRate = 25;
            Console.WriteLine("Your subscription expires within a day!");
            Console.WriteLine("Renew now and save " + discountRate + "%!");
        }
        else if (daysLeft <= 5)
        {
            discountRate = 15;
            Console.WriteLine("Your subscription expires in " + daysLeft + " days.");
            Console.WriteLine("Renew now and save " + discountRate + "%!");
        }
        else if (daysLeft <= 10)
        {
            discountRate = 5;
            Console.WriteLine("Your subscription expires in " + daysLeft + " days.");
            Console.WriteLine("Your subscription will expire soon. Renew now and save " + discountRate + "%!");
        }
        else
        {
            Console.WriteLine("You have more than 10 days left on your subscription.");
            Console.WriteLine("Consider renewing to avoid last-minute rush!");
        }
    }
}
