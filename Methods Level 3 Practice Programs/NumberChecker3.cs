using System;
using System.Collections.Generic;
using System.Text;

namespace Methods_Level_3_Practice_Programs
{
    internal class NumberChecker3
    {
        public static void display()
        {
            Console.Write("Enter Number : ");
            int number = int.Parse(Console.ReadLine());

            int count = CountDigits(number);
            int[] digits = GetDigits(number, count);

            int[] reversed = ReverseArray(digits);

            Console.WriteLine("Palindrome : " + IsPalindrome(digits, reversed));
            Console.WriteLine("Duck Number : " + IsDuckNumber(digits));
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

        public static int[] ReverseArray(int[] digits)
        {
            int[] reverse = new int[digits.Length];

            for (int i = 0; i < digits.Length; i++)
            {
                reverse[i] = digits[digits.Length - 1 - i];
            }

            return reverse;
        }

        public static bool CompareArrays(int[] arr1, int[] arr2)
        {
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                    return false;
            }

            return true;
        }

        public static bool IsPalindrome(int[] digits, int[] reverse)
        {
            return CompareArrays(digits, reverse);
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
    }
}