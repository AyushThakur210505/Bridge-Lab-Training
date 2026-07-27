using System;
using System.Collections.Generic;
using System.Text;

namespace Methods_Level_3_Practice_Programs
{
    internal class FootballTeamHeight
    {
        public static void display()
        {
            int[] heights = GenerateHeights();

            Console.WriteLine("Player Heights:");

            foreach (int height in heights)
            {
                Console.Write(height + " ");
            }

            Console.WriteLine();

            Console.WriteLine("Mean Height : " + FindMean(heights).ToString("F2"));
            Console.WriteLine("Shortest Height : " + FindShortest(heights));
            Console.WriteLine("Tallest Height : " + FindTallest(heights));
        }

        public static int[] GenerateHeights()
        {
            Random random = new Random();
            int[] heights = new int[11];

            for (int i = 0; i < heights.Length; i++)
            {
                heights[i] = random.Next(150, 251);
            }

            return heights;
        }

        public static int FindSum(int[] heights)
        {
            int sum = 0;

            foreach (int height in heights)
            {
                sum += height;
            }

            return sum;
        }

        public static double FindMean(int[] heights)
        {
            return (double)FindSum(heights) / heights.Length;
        }

        public static int FindShortest(int[] heights)
        {
            int shortest = heights[0];

            foreach (int height in heights)
            {
                if (height < shortest)
                    shortest = height;
            }

            return shortest;
        }

        public static int FindTallest(int[] heights)
        {
            int tallest = heights[0];

            foreach (int height in heights)
            {
                if (height > tallest)
                    tallest = height;
            }

            return tallest;
        }
    }
}
