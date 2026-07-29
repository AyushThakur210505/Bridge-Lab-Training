using System;
using System.Collections.Generic;
using System.Text;

namespace Built_In_Function_Practice_Problem
{
    internal class MaximumOfThreeNumbers
    {
        public static void display()
        {
            int num1 = GetNumber("Enter First Number: ");
            int num2 = GetNumber("Enter Second Number: ");
            int num3 = GetNumber("Enter Third Number: ");

            int maximum = FindMaximum(num1, num2, num3);

            Console.WriteLine("Maximum Number = " + maximum);
        }

        public static int GetNumber(string message)
        {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        }

        public static int FindMaximum(int num1, int num2, int num3)
        {
            int max = num1;

            if (num2 > max)
            {
                max = num2;
            }

            if (num3 > max)
            {
                max = num3;
            }

            return max;
        }
    }
}
