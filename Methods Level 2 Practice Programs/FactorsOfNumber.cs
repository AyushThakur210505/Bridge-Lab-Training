using System;
using System.Collections.Generic;
using System.Text;

namespace Methods_Level_2_Practice_Programs
{
    internal class FactorsOfNumber
    {
        public static void display()
        {
            Console.Write("Enter a Number : ");
            int number = int.Parse(Console.ReadLine());

            int[] factors = GetFactors(number);

            Console.Write("Factors : ");
            foreach (int factor in factors)
            {
                Console.Write(factor + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Sum of Factors : " + FindSum(factors));
            Console.WriteLine("Product of Factors : " + FindProduct(factors));
            Console.WriteLine("Sum of Squares of Factors : " + FindSumOfSquares(factors));
        }

        public static int[] GetFactors(int number)
        {
            int count = 0;

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    count++;
                }
            }

            int[] factors = new int[count];
            int index = 0;

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    factors[index] = i;
                    index++;
                }
            }

            return factors;
        }

        public static int FindSum(int[] factors)
        {
            int sum = 0;

            foreach (int factor in factors)
            {
                sum += factor;
            }

            return sum;
        }

        public static int FindProduct(int[] factors)
        {
            int product = 1;

            foreach (int factor in factors)
            {
                product *= factor;
            }

            return product;
        }

        public static double FindSumOfSquares(int[] factors)
        {
            double sum = 0;

            foreach (int factor in factors)
            {
                sum += Math.Pow(factor, 2);
            }

            return sum;
        }
    }
}
