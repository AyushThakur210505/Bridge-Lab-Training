using System;
using System.Collections.Generic;
using System.Text;

namespace Methods_Level_1_Practice_Programs
{
    internal class QuotientAndRemainder
    {
        public static void display()
        {
            Console.Write("Enter Number : ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Enter Divisor : ");
            int divisor = int.Parse(Console.ReadLine());

            int[] result = checker(number, divisor);

            Console.WriteLine("Quotient : " + result[0]);
            Console.WriteLine("Remainder : " + result[1]);
        }

        public static int[] checker(int number, int divisor)
        {
            int quotient = number / divisor;
            int remainder = number % divisor;

            return new int[] { quotient, remainder };
        }
    }
}