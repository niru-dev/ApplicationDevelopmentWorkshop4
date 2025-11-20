using System;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create one object using default constructor
            var player1 = new Player();

            // Create another object using parameterized constructor
            var player2 = new Player("Alice", 5, 100);

            // Print the values of the fields using both objects
            Console.WriteLine("Player 1 values:");
            Console.WriteLine(player1.ToString());

            Console.WriteLine("Player 2 values:");
            Console.WriteLine(player2.ToString());
        }
    }
}