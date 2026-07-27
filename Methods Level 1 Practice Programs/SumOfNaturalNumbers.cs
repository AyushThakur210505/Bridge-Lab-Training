using System;
using System.Collections.Generic;
using System.Text;

namespace Methods_Level_1_Practice_Programs
{
    internal class SumOfNaturalNumbers
    {
        public static void display()
        {
            Console.Write("Enter a Number : ");
            int num = int.Parse(Console.ReadLine());
            int result = sum(num);

            Console.WriteLine($"Sum of {num} natural number is {result}");
        }
        public static int sum(int num)
        {
            int total = 0;
            for(int i = 0; i <= num; i++)
            {
                total += i;
            }
            return total;
        }
    }
}
