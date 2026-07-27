using System;
using System.Collections.Generic;
using System.Text;

namespace Methods_Level_2_Practice_Programs
{
    internal class SumOfNaturalNumbersRecursion
    {
        public static void display()
        {
            Console.Write("Enter a Natural Number : ");
            int number = int.Parse(Console.ReadLine());

            if (number <= 0)
            {
                Console.WriteLine("Please enter a Natural Number.");
                return;
            }

            int recursiveSum = FindSumRecursion(number);
            int formulaSum = FindSumFormula(number);

            Console.WriteLine("Sum using Recursion : " + recursiveSum);
            Console.WriteLine("Sum using Formula : " + formulaSum);

            if (recursiveSum == formulaSum)
                Console.WriteLine("Both results are equal.");
            else
                Console.WriteLine("Results are not equal.");
        }

        public static int FindSumRecursion(int number)
        {
            if (number == 1)
                return 1;

            return number + FindSumRecursion(number - 1);
        }

        public static int FindSumFormula(int number)
        {
            return number * (number + 1) / 2;
        }
    }
}