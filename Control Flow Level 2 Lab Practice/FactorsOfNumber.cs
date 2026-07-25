using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Flow_Level_2_Lab_Practice
{
    internal class FactorsOfNumber
    {
        public static void display()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Factors are:");

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}