using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays_Level_2_Lab_Practice
{
    internal class DigitFrequency
    {
        public static void display()
        {
            Console.Write("Enter a Number : ");
            int number = int.Parse(Console.ReadLine());

            int temp = number;
            int count = 0;

            while (temp > 0)
            {
                count++;
                temp = temp / 10;
            }

            int[] digit = new int[count];

            temp = number;

            for (int i = 0; i < count; i++)
            {
                digit[i] = temp % 10;
                temp = temp / 10;
            }

            int[] frequency = new int[10];

            for (int i = 0; i < digit.Length; i++)
            {
                frequency[digit[i]]++;
            }

            for (int i = 0; i < frequency.Length; i++)
            {
                if (frequency[i] > 0)
                {
                    Console.WriteLine(i + " = " + frequency[i]);
                }
            }
        }
    }
}
