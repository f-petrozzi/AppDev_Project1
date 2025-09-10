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
<<<<<<< HEAD
=======

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Maximum Heart Rate Calculator ===");

        // Ask for user input
        Console.Write("Enter your age: ");
        string input = Console.ReadLine();

        // Validate input
        if (int.TryParse(input, out int age) && age > 0)
        {
            int maxHeartRate = 220 - age;

            Console.WriteLine($"Your maximum heart rate is approximately {maxHeartRate} beats per minute (bpm).");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid positive number for age.");
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
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

>>>>>>> 4f41aacd5bb0a3e22fc58b6f6417f30a05034da5
