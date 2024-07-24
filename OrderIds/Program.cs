using System;

class Program
{
    static void Main()
    {
        // Array of predefined order IDs
        string[] orderIds = { "X123", "Y234", "Z345", "X15", "Y177", "Z3003", "Y235", "X179" };

        // Print order IDs that end with a digit greater than 5
        Console.WriteLine("Order IDs ending with a digit greater than 5:");
        foreach (string item in orderIds)
        {
            // Check if the last character is a digit and if it is greater than 5
            if (char.IsDigit(item[item.Length - 1]) && (item[item.Length - 1] > '5'))
            {
                Console.WriteLine(item);
            }
        }

        // Generate random order IDs
        Random random = new Random();
        string[] generatedOrderIDs = new string[5];

        for (int i = 0; i < generatedOrderIDs.Length; i++)
        {
            int prefixValue = random.Next(88, 91); // Letters X to Z (ASCII 88-90)
            string prefix = Convert.ToChar(prefixValue).ToString();
            string suffix = random.Next(1000, 10000).ToString("0000"); // Four-digit number

            generatedOrderIDs[i] = prefix + suffix;
        }

        // Print generated order IDs
        Console.WriteLine("\nGenerated Order IDs:");
        foreach (var orderID in generatedOrderIDs)
        {
            Console.WriteLine(orderID);
        }
    }
}

