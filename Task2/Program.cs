namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator.PrintWelcome();
            int sum = Calculator.Add(5, 5);
            Console.WriteLine($"Sum: {sum}");
            int product = Calculator.Multiply(7);
            Console.WriteLine($"Product: {product}");

        }
    }
}