using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays_Level_2_Lab_Practice
{
    internal class DynamicLargestSecondLargestDigit
    {
        public static void display()
        {
            Console.Write("Enter a Number : ");
            long number = long.Parse(Console.ReadLine());

            int maxDigit = 10;
            int[] digit = new int[maxDigit];
            int index = 0;

            while (number > 0)
            {
                if (index == maxDigit)
                {
                    maxDigit = maxDigit + 10;

                    int[] temp = new int[maxDigit];

                    for (int i = 0; i < digit.Length; i++)
                    {
                        temp[i] = digit[i];
                    }

                    digit = temp;
                }

                digit[index] = (int)(number % 10);
                number = number / 10;
                index++;
            }

            int largest = digit[0];
            int secondLargest = digit[0];

            for (int i = 1; i < index; i++)
            {
                if (digit[i] > largest)
                {
                    secondLargest = largest;
                    largest = digit[i];
                }
                else if (digit[i] > secondLargest && digit[i] != largest)
                {
                    secondLargest = digit[i];
                }
            }

            Console.WriteLine("Largest Digit : " + largest);
            Console.WriteLine("Second Largest Digit : " + secondLargest);
        }
    }
}