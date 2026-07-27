using System;
using System.Collections.Generic;
using System.Text;

namespace Methods_Level_2_Practice_Programs
{
    internal class YoungestAndTallestFriend
    {
        public static void display()
        {
            string[] names = { "Amar", "Akbar", "Anthony" };

            int[] ages = new int[3];
            double[] heights = new double[3];

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Enter Age of {names[i]} : ");
                ages[i] = int.Parse(Console.ReadLine());

                Console.Write($"Enter Height of {names[i]} (in cm) : ");
                heights[i] = double.Parse(Console.ReadLine());
            }

            int youngest = FindYoungest(ages);
            int tallest = FindTallest(heights);

            Console.WriteLine("\nYoungest Friend : " + names[youngest]);
            Console.WriteLine("Tallest Friend : " + names[tallest]);
        }

        public static int FindYoungest(int[] ages)
        {
            int index = 0;

            for (int i = 1; i < ages.Length; i++)
            {
                if (ages[i] < ages[index])
                    index = i;
            }

            return index;
        }

        public static int FindTallest(double[] heights)
        {
            int index = 0;

            for (int i = 1; i < heights.Length; i++)
            {
                if (heights[i] > heights[index])
                    index = i;
            }

            return index;
        }
    }
}
