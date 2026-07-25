using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Flow_Level_3_Lab_Practice
{
    internal class HarshadNumberChecker
    {
        public static void display()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            int temp = number;
            int sum = 0;

            while (temp != 0)
            {
                int digit = temp % 10;
                sum += digit;
                temp /= 10;
            }

            if (number % sum == 0)
            {
                Console.WriteLine(number + " is a Harshad Number.");
            }
            else
            {
                Console.WriteLine(number + " is not a Harshad Number.");
            }
        }
    }
}