using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    internal class MeanHeightCalculator
    {
        public static void display()
        {
            double[] heights = new double[11];
            double sum = 0;

            Console.WriteLine("Enter the height of 11 football players (in cm):");

            for (int i = 0; i < heights.Length; i++)
            {
                Console.Write("Player " + (i + 1) + ": ");
                heights[i] = double.Parse(Console.ReadLine());

                sum += heights[i];
            }

            double meanHeight = sum / heights.Length;

            Console.WriteLine("\nHeights of Players:");
            for (int i = 0; i < heights.Length; i++)
            {
                Console.WriteLine("Player " + (i + 1) + " = " + heights[i] + " cm");
            }

            Console.WriteLine("\nMean Height of the Football Team = " + meanHeight.ToString("F2") + " cm");
        }
    }
}
