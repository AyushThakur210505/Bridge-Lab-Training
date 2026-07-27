using System;
using System.Collections.Generic;
using System.Text;

namespace Methods_Level_1_Practice_Programs
{
    internal class SmallestAndLargest
    {
        public static void display()
        {
            int[] arr = new int[3];

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Enter number {i + 1} : ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            int[] result = checker(arr);

            Console.WriteLine("Smallest Number : " + result[0]);
            Console.WriteLine("Largest Number  : " + result[1]);
        }

        public static int[] checker(int[] arr)
        {
            int smallest = arr[0];
            int largest = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < smallest)
                {
                    smallest = arr[i];
                }

                if (arr[i] > largest)
                {
                    largest = arr[i];
                }
            }

            return new int[] { smallest, largest };
        }
    }
}