using System;

class Program
{
    static void Main()
    {
        string s = "The quick brown fox jumps over the lazy dog";
        
        // Split the string into words
        string[] subs = s.Split(' ');
        
        foreach (var sub in subs)
        {
            // Convert each word to uppercase
            string result = sub.ToUpper();
            Console.WriteLine(result);
        }
    }
}

