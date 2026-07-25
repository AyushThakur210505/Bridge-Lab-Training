using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Flow_Level_1_Lab_Practice
{
    internal class FactorialWhile
    {
        public static void display()
        {
            Console.Write("Enter a Number : ");
            int num = int.Parse(Console.ReadLine());

            if (num < 0)
            {
                Console.WriteLine("Entered Number is Not Positive");
            }
            else if (num == 0)
            {
                Console.WriteLine($"Factorial of the {num} is : 0");
            }
            else
            {
                int total = 1;
                int temp = num;

                while (temp > 0)
                {
                    total *= temp;
                    temp--;
                }
                Console.WriteLine($"Factorial of the {num} is : {total}");
            }
        }
    }
}
