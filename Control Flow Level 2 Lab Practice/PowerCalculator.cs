using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Flow_Level_2_Lab_Practice
{
    internal class PowerCalculator
    {
        public static void display()
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Enter power: ");
            int power = int.Parse(Console.ReadLine());

            int result = 1;

            for (int i = 1; i <= power; i++)
            {
                result *= number;
            }

            Console.WriteLine("Result: " + result);
        }
    }
}
