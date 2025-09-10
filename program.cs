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

namespace DensityCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Density Calculator ===");

            // Prompt for mass
            Console.Write("Enter the mass of the object (in kilograms): ");
            if (!double.TryParse(Console.ReadLine(), out double mass) || mass <= 0)
            {
                Console.WriteLine("Invalid input. Mass must be a positive number.");
                return;
            }

            // Prompt for volume
            Console.Write("Enter the volume of the object (in cubic meters): ");
            if (!double.TryParse(Console.ReadLine(), out double volume) || volume <= 0)
            {
                Console.WriteLine("Invalid input. Volume must be a positive number.");
                return;
            }

            // Calculate density
            double density = mass / volume;

            // Display result
            Console.WriteLine($"\nThe density of the object is {density:F2} kg/m³");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
