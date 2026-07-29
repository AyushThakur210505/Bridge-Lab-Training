using System;
using System.Collections.Generic;
using System.Text;

namespace Built_In_Function_Practice_Problem
{
    internal class PrimeNumberChecker
    {
        public static void display()
        {
            int number = GetNumber();

            if (IsPrime(number))
                Console.WriteLine(number + " is a Prime Number.");
            else
                Console.WriteLine(number + " is Not a Prime Number.");
        }

        public static int GetNumber()
        {
            Console.Write("Enter a Number: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        public static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }
    }
}