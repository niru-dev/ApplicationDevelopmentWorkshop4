using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public static class ParameterDemo
    {
        public static void Increase(ref int number)
        {
            number += 10;
        }
        public static void GetFullName(out string fullName)
        {
            fullName = "Dikshu Ghimire";
        }

        public static int SumAll(params int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum;
        }

    }
}