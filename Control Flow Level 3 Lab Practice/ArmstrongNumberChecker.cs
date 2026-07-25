using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Flow_Level_3_Lab_Practice
{
    internal class ArmstrongNumberChecker
    {
        public static void display()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            int originalNumber = number;
            int sum = 0;

            while (originalNumber != 0)
            {
                int digit = originalNumber % 10;
                sum += digit * digit * digit;
                originalNumber /= 10;
            }

            if (sum == number)
            {
                Console.WriteLine(number + " is an Armstrong Number.");
            }
            else
            {
                Console.WriteLine(number + " is not an Armstrong Number.");
            }
        }
    }
}
