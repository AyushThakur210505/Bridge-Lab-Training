using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays_Level_2_Lab_Practice
{
    internal class LargestSecondLargestDigit
    {
        public static void display()
        {
            Console.Write("Enter a Number : ");
            int number = int.Parse(Console.ReadLine());

            int[] digit = new int[10];
            int index = 0;

            while (number > 0)
            {
                digit[index] = number % 10;
                number = number / 10;
                index++;

                if (index == 10)
                {
                    break;
                }
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