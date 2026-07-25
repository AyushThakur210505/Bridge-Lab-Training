using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Flow_Level_1_Lab_Practice
{
    internal class NaturalNumberSum
    {
        public static void display()
        {
            Console.Write("Enter a Number : ");
            int num = int.Parse(Console.ReadLine());

            if (num <= 0)
            {
                Console.WriteLine($"The Number {num} is not a natural number");
            }
            else
            {
                Console.WriteLine($"The sum of {num} natural number is {(num * (num + 1)) / 2}");
            }
        }
    }
}
