using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Flow_Level_3_Lab_Practice
{
    internal class AbundantNumberChecker
    {
        public static void display()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }

            if (sum > number)
            {
                Console.WriteLine(number + " is an Abundant Number.");
            }
            else
            {
                Console.WriteLine(number + " is not an Abundant Number.");
            }
        }
    }
}