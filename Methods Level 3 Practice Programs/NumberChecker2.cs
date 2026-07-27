using System;
using System.Collections.Generic;
using System.Text;

namespace Methods_Level_3_Practice_Programs
{
    internal class NumberChecker2
    {
        public static void display()
        {
            Console.Write("Enter Number : ");
            int number = int.Parse(Console.ReadLine());

            int count = CountDigits(number);
            int[] digits = GetDigits(number, count);

            Console.WriteLine("Sum of Digits : " + SumOfDigits(digits));
            Console.WriteLine("Sum of Squares : " + SumOfSquares(digits));

            if (IsHarshad(number, digits))
                Console.WriteLine("Harshad Number");
            else
                Console.WriteLine("Not a Harshad Number");

            int[,] frequency = DigitFrequency(digits);

            Console.WriteLine("\nDigit\tFrequency");

            for (int i = 0; i < 10; i++)
            {
                if (frequency[i, 1] > 0)
                {
                    Console.WriteLine(frequency[i, 0] + "\t" + frequency[i, 1]);
                }
            }
        }

        public static int CountDigits(int number)
        {
            int count = 0;

            while (number > 0)
            {
                count++;
                number /= 10;
            }

            return count;
        }

        public static int[] GetDigits(int number, int count)
        {
            int[] digits = new int[count];

            for (int i = count - 1; i >= 0; i--)
            {
                digits[i] = number % 10;
                number /= 10;
            }

            return digits;
        }

        public static int SumOfDigits(int[] digits)
        {
            int sum = 0;

            foreach (int digit in digits)
                sum += digit;

            return sum;
        }

        public static double SumOfSquares(int[] digits)
        {
            double sum = 0;

            foreach (int digit in digits)
                sum += Math.Pow(digit, 2);

            return sum;
        }

        public static bool IsHarshad(int number, int[] digits)
        {
            return number % SumOfDigits(digits) == 0;
        }

        public static int[,] DigitFrequency(int[] digits)
        {
            int[,] frequency = new int[10, 2];

            for (int i = 0; i < 10; i++)
            {
                frequency[i, 0] = i;
            }

            foreach (int digit in digits)
            {
                frequency[digit, 1]++;
            }

            return frequency;
        }
    }
}
