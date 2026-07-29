using System;
using System.Collections.Generic;
using System.Text;

namespace Built_In_Function_Practice_Problem
{
    internal class FactorialUsingRecursion
    {
        public static void display()
        {
            int number = GetNumber();

            long factorial = CalculateFactorial(number);

            Console.WriteLine("Factorial of " + number + " = " + factorial);
        }

        public static int GetNumber()
        {
            Console.Write("Enter a Number: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        public static long CalculateFactorial(int number)
        {
            if (number == 0 || number == 1)
                return 1;

            return number * CalculateFactorial(number - 1);
        }
    }
}