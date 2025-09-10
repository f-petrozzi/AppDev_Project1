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

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Perimeter of a Square Calculator ===");

        // Ask the user for the length of one side
        Console.Write("Enter the length of a side: ");
        string input = Console.ReadLine();

        // Convert input to a number
        double side;
        if (double.TryParse(input, out side) && side > 0)
        {
            // Formula for perimeter of a square: 4 × side
            double perimeter = 4 * side;

            Console.WriteLine($"The perimeter of the square is: {perimeter}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a positive number.");
        }
    }
}
