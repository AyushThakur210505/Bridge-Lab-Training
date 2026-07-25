using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Flow_Level_3_Lab_Practice
{
    internal class DigitCounter
    {
        public static void display()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            int count = 0;
            int temp = number;

            if (temp == 0)
            {
                count = 1;
            }
            else
            {
                while (temp != 0)
                {
                    count++;
                    temp /= 10;
                }
            }

            Console.WriteLine("Number of digits: " + count);
        }
    }
}