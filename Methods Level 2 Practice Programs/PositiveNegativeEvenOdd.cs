using System;
using System.Collections.Generic;
using System.Text;

namespace Methods_Level_2_Practice_Programs
{
    internal class PositiveNegativeEvenOdd
    {
        public static void display()
        {
            int[] numbers = new int[5];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Enter Number {i + 1} : ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nResult:");

            foreach (int number in numbers)
            {
                if (IsPositive(number))
                {
                    Console.Write(number + " is Positive and ");

                    if (IsEven(number))
                        Console.WriteLine("Even");
                    else
                        Console.WriteLine("Odd");
                }
                else
                {
                    Console.WriteLine(number + " is Negative");
                }
            }

            int compare = Compare(numbers[0], numbers[4]);

            if (compare == 1)
                Console.WriteLine("\nFirst number is Greater than Last number.");
            else if (compare == 0)
                Console.WriteLine("\nFirst number is Equal to Last number.");
            else
                Console.WriteLine("\nFirst number is Less than Last number.");
        }

        public static bool IsPositive(int number)
        {
            return number >= 0;
        }

        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        public static int Compare(int number1, int number2)
        {
            if (number1 > number2)
                return 1;
            else if (number1 == number2)
                return 0;
            else
                return -1;
        }
    }
}