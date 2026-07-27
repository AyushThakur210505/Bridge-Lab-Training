using System;
using System.Collections.Generic;
using System.Text;

namespace Methods_Level_3_Practice_Programs
{
    internal class CollinearPoints
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

            Console.Write("Enter x3 : ");
            double x3 = double.Parse(Console.ReadLine());

            Console.Write("Enter y3 : ");
            double y3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Using Slope Method : " + IsCollinearSlope(x1, y1, x2, y2, x3, y3));
            Console.WriteLine("Using Area Method : " + IsCollinearArea(x1, y1, x2, y2, x3, y3));
        }

        public static bool IsCollinearSlope(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            double slopeAB = (y2 - y1) / (x2 - x1);
            double slopeBC = (y3 - y2) / (x3 - x2);

            return slopeAB == slopeBC;
        }

        public static bool IsCollinearArea(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            double area = 0.5 * (x1 * (y2 - y3) + x2 * (y3 - y1) +x3 * (y1 - y2));
            return area == 0;
        }
    }
}
