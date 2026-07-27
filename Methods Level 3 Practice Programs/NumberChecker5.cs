using System;
using System.Collections.Generic;
using System.Text;

namespace Methods_Level_3_Practice_Programs
{
    internal class NumberChecker5
    {
        public static void display()
        {
            Console.Write("Enter Number : ");
            int number = int.Parse(Console.ReadLine());

            int[] factors = GetFactors(number);

            Console.Write("Factors : ");
            foreach (int factor in factors)
            {
                Console.Write(factor + " ");
            }

            Console.WriteLine("\nGreatest Factor : " + GreatestFactor(factors));
            Console.WriteLine("Sum of Factors : " + SumFactors(factors));
            Console.WriteLine("Product of Factors : " + ProductFactors(factors));
            Console.WriteLine("Product of Cubes : " + ProductOfCubes(factors));

            Console.WriteLine("Perfect Number : " + IsPerfect(number));
            Console.WriteLine("Abundant Number : " + IsAbundant(number));
            Console.WriteLine("Deficient Number : " + IsDeficient(number));
            Console.WriteLine("Strong Number : " + IsStrong(number));
        }

        public static int[] GetFactors(int number)
        {
            int count = 0;

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                    count++;
            }

            int[] factors = new int[count];
            int index = 0;

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                    factors[index++] = i;
            }

            return factors;
        }

        public static int GreatestFactor(int[] factors)
        {
            return factors[factors.Length - 1];
        }

        public static int SumFactors(int[] factors)
        {
            int sum = 0;

            foreach (int factor in factors)
                sum += factor;

            return sum;
        }

        public static int ProductFactors(int[] factors)
        {
            int product = 1;

            foreach (int factor in factors)
                product *= factor;

            return product;
        }

        public static double ProductOfCubes(int[] factors)
        {
            double product = 1;

            foreach (int factor in factors)
                product *= Math.Pow(factor, 3);

            return product;
        }

        public static bool IsPerfect(int number)
        {
            int sum = 0;

            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                    sum += i;
            }

            return sum == number;
        }

        public static bool IsAbundant(int number)
        {
            int sum = 0;

            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                    sum += i;
            }

            return sum > number;
        }

        public static bool IsDeficient(int number)
        {
            int sum = 0;

            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                    sum += i;
            }

            return sum < number;
        }

        public static bool IsStrong(int number)
        {
            int temp = number;
            int sum = 0;

            while (temp > 0)
            {
                int digit = temp % 10;
                int factorial = 1;

                for (int i = 1; i <= digit; i++)
                    factorial *= i;

                sum += factorial;
                temp /= 10;
            }

            return sum == number;
        }
    }
}
