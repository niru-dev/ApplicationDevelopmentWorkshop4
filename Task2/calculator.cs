using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public static class Calculator
    {
        public static void PrintWelcome()
        {
            Console.WriteLine("Welcome to the Calculator!");
        }

        public static int Add(int num1, int num2)
        {
            int result = num1 + num2;
            return result;

        }

        public static int Multiply(int num1, int num2 = 1)
        {
            int result = num1 * num2;
            return result;
        }


    }
}