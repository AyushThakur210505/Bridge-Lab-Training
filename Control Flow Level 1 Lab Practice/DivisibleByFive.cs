using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Flow_Level_1_Lab_Practice
{
    internal class DivisibleByFive
    {
        public static void display()
        {
            Console.Write("Enter a Number : ");
            int num = int.Parse(Console.ReadLine());
            if (num % 5 == 0)
            {
                Console.WriteLine($"The Number {num} is divisible By 5");
            }
            else
            {
                Console.WriteLine($"The Number {num} is not divisible By 5");
            }
        }
    }
}
