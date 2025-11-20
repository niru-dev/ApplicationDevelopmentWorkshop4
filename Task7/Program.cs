using System;

namespace Task_7
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("OOP principle: Encapsulation\n");
            Console.WriteLine("Classes and objects:");
            Console.WriteLine("- Class: a blueprint that defines data (fields/properties) and behavior (methods).");
            Console.WriteLine("- Object: an instance of a class with concrete state that can execute the behavior.\n");

            // Example1: BankAccount demonstrates encapsulation
            var account = new BankAccount("Alice", 100m);
            Console.WriteLine($"Created account for {account.Owner} with balance {account.Balance:C}");

            account.Deposit(50m);
            Console.WriteLine($"After deposit: {account.Balance:C}");

            try
            {
                account.Withdraw(200m);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Withdraw failed: {ex.Message}");
            }

            account.Withdraw(75m);
            Console.WriteLine($"After withdraw: {account.Balance:C}\n");

            // Example2: AppSettings demonstrates encapsulation with validation
            var settings = new AppSettings();
            try
            {
                settings.ConnectionString = "Server=myserver;Database=mydb;";
                settings.MaxConnections = 20; // valid
                Console.WriteLine($"Settings: ConnectionString='{settings.ConnectionString}', MaxConnections={settings.MaxConnections}");

                settings.MaxConnections = -5; // invalid, will throw
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Settings update failed: {ex.Message}");
            }

            // End
            Console.WriteLine("\nDemonstration complete.");
        }
    }
}

 