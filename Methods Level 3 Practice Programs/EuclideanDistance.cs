using System;
using System.Collections.Generic;
using System.Text;

namespace Methods_Level_3_Practice_Programs
{
    internal class EuclideanDistance
    {
        public static void display()
        {
            Console.Write("Enter x1 : ");
            double x1 = double.Parse(Console.ReadLine());

            Console.Write("Enter y1 : ");
            double y1 = double.Parse(Console.ReadLine());

            Console.Write("Enter x2 : ");
            double x2 = double.Parse(Console.ReadLine());

            Console.Write("Enter y2 : ");
            double y2 = double.Parse(Console.ReadLine());

            double distance = FindDistance(x1, y1, x2, y2);
            double[] equation = FindLineEquation(x1, y1, x2, y2);

            Console.WriteLine("Euclidean Distance : " + distance.ToString("F2"));
            Console.WriteLine("Slope (m) : " + equation[0].ToString("F2"));
            Console.WriteLine("Y-Intercept (b) : " + equation[1].ToString("F2"));
            Console.WriteLine($"Equation : y = {equation[0]:F2}x + {equation[1]:F2}");
        }

        public static double FindDistance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        public static double[] FindLineEquation(double x1, double y1, double x2, double y2)
        {
            double slope = (y2 - y1) / (x2 - x1);
            double intercept = y1 - (slope * x1);

            return new double[] { slope, intercept };
        }
    }
}
