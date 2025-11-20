using System;

namespace Task5
{
    enum DayType
    {
        Weekday,
        Weekend
    }

    public record Book(string title, string author, double price);

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a day (e.g. \"Sunday\"): ");
            var input = Console.ReadLine()?.Trim() ?? string.Empty;

            var isWeekend = string.Equals(input, "Friday", StringComparison.OrdinalIgnoreCase)
                            || string.Equals(input, "Saturday", StringComparison.OrdinalIgnoreCase);

            var dayType = isWeekend ? DayType.Weekend : DayType.Weekday;
            Console.WriteLine($"It is: {dayType}");

            var book1 = new Book("The Pragmatic Programmer", "Andrew Hunt & David Thomas", 39.99);

            var book2 = book1 with { title = "The Pragmatic Programmer - 20th Anniversary Edition", price = 49.99 };

            Console.WriteLine();
            Console.WriteLine("First book (original):");
            Console.WriteLine(book1);

            var (title, author, price) = book2;
            Console.WriteLine();
            Console.WriteLine("Second book (after with-expression) deconstructed values:");
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Author: {author}");
            Console.WriteLine($"Price: {price}");
        }
    }
}