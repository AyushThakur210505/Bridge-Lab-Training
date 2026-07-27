using System;
using System.Collections.Generic;
using System.Text;

namespace Methods_Level_3_Practice_Programs
{
    internal class NumberChecker1
    {
        public static void display()
        {
            Console.Write("Enter Number : ");
            int number = int.Parse(Console.ReadLine());

            int count = CountDigits(number);
            int[] digits = GetDigits(number, count);

            Console.WriteLine("Digit Count : " + count);
            Console.WriteLine("Duck Number : " + IsDuckNumber(digits));
            Console.WriteLine("Armstrong Number : " + IsArmstrong(number, digits));

            int[] largest = LargestSecondLargest(digits);
            Console.WriteLine("Largest Digit : " + largest[0]);
            Console.WriteLine("Second Largest Digit : " + largest[1]);

            int[] smallest = SmallestSecondSmallest(digits);
            Console.WriteLine("Smallest Digit : " + smallest[0]);
            Console.WriteLine("Second Smallest Digit : " + smallest[1]);
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

        public static bool IsDuckNumber(int[] digits)
        {
            for (int i = 1; i < digits.Length; i++)
            {
                if (digits[i] == 0)
                    return true;
            }

            return false;
        }

        public static bool IsArmstrong(int number, int[] digits)
        {
            int sum = 0;

            foreach (int digit in digits)
            {
                sum += (int)Math.Pow(digit, digits.Length);
            }

            return sum == number;
        }

        public static int[] LargestSecondLargest(int[] digits)
        {
            int largest = int.MinValue;
            int secondLargest = int.MinValue;

            foreach (int digit in digits)
            {
                if (digit > largest)
                {
                    secondLargest = largest;
                    largest = digit;
                }
                else if (digit > secondLargest && digit != largest)
                {
                    secondLargest = digit;
                }
            }

            return new int[] { largest, secondLargest };
        }

        public static int[] SmallestSecondSmallest(int[] digits)
        {
            int smallest = int.MaxValue;
            int secondSmallest = int.MaxValue;

            foreach (int digit in digits)
            {
                if (digit < smallest)
                {
                    secondSmallest = smallest;
                    smallest = digit;
                }
                else if (digit < secondSmallest && digit != smallest)
                {
                    secondSmallest = digit;
                }
            }

            return new int[] { smallest, secondSmallest };
        }
    }
}