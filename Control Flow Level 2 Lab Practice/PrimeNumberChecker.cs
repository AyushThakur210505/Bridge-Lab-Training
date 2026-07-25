using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Flow_Level_2_Lab_Practice
{
    internal class PrimeNumberChecker
    {
        public static void display()
        {
            Console.Write("Enter a Number : ");
            int num = int.Parse(Console.ReadLine());
            bool isPrime = true;

            if (num <= 1)
            {
                isPrime = false;

            }
            else
            {
                for(int i = 2; i < num; i++)
                {
                    if(num%i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }
            if (isPrime)
            {
                Console.WriteLine($"The number {num} is a prime number");
            }
            else
            {
                Console.WriteLine($"The number {num} is not a prime number");
            }
        }
    }
}
