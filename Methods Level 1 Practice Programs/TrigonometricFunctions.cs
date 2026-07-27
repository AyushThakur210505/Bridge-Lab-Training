using System;
using System.Collections.Generic;
using System.Text;

namespace Methods_Level_1_Practice_Programs
{
    internal class TrigonometricFunctions
    {
        public static void display()
        {
            Console.Write("Enter Angle (in Degrees) : ");
            double angle = double.Parse(Console.ReadLine());

            double[] result = checker(angle);

            Console.WriteLine("Sin = " + result[0].ToString("F4"));
            Console.WriteLine("Cos = " + result[1].ToString("F4"));
            Console.WriteLine("Tan = " + result[2].ToString("F4"));
        }

        public static double[] checker(double angle)
        {
            double radians = angle * Math.PI / 180;

            double sin = Math.Sin(radians);
            double cos = Math.Cos(radians);
            double tan = Math.Tan(radians);

            return new double[] { sin, cos, tan };
        }
    }
}
