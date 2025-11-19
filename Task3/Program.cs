namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ParameterDemo.SumAll(1, 2, 3, 4, 5);

            int value = 25;
            ParameterDemo.Increase(ref value);
            System.Console.WriteLine($"Increased value: {value}");

            string fullName;
            ParameterDemo.GetFullName(out fullName);
            System.Console.WriteLine($"Full name: {fullName}");
        }
    }
}