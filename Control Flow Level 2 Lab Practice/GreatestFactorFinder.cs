using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Flow_Level_2_Lab_Practice
{
    internal class GreatestFactorFinder
    {
        public static void display()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            int greatestFactor = 1;

            for (int i = number - 1; i >= 1; i--)
            {
                if (number % i == 0)
                {
                    greatestFactor = i;
                    break;
                }
            }

            Console.WriteLine("Greatest Factor: " + greatestFactor);
        }
    }
}
