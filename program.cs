using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a sentence:");
        string input = Console.ReadLine();

        int letterCount = 0;

        foreach (char c in input)
        {
            if (char.IsLetter(c))
            {
                letterCount++;
            }
        }

        Console.WriteLine($"The sentence has {letterCount} letters.");
    }
}