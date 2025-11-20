using System;

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter marks (integer): ");
            var marksInput = Console.ReadLine()?.Trim() ?? string.Empty;
            if (!int.TryParse(marksInput, out int marks))
            {
                Console.WriteLine("Invalid input for marks. Please enter an integer.");
                return;
            }

            Console.Write("Enter total (integer): ");
            var totalInput = Console.ReadLine()?.Trim() ?? string.Empty;
            if (!int.TryParse(totalInput, out int total))
            {
                Console.WriteLine("Invalid input for total. Please enter an integer.");
                return;
            }

            if (total == 0)
            {
                Console.WriteLine("Total cannot be zero.");
                return;
            }

            double percentage = (double)marks / total * 100.0;

            Console.WriteLine($"Percentage: {percentage:F2}%");
        }
    }
}