using System;
using System.Collections.Generic;
using System.Text;

namespace Methods_Level_2_Practice_Programs
{
    internal class UnitConverter2
    {
        public static void display()
        {
            Console.Write("Enter Yards : ");
            double yards = double.Parse(Console.ReadLine());

            Console.Write("Enter Feet : ");
            double feet = double.Parse(Console.ReadLine());

            Console.Write("Enter Meters : ");
            double meters = double.Parse(Console.ReadLine());

            Console.Write("Enter Inches : ");
            double inches = double.Parse(Console.ReadLine());

            Console.WriteLine("\nConversions:");
            Console.WriteLine("Yards to Feet : " + ConvertYardsToFeet(yards).ToString("F2"));
            Console.WriteLine("Feet to Yards : " + ConvertFeetToYards(feet).ToString("F2"));
            Console.WriteLine("Meters to Inches : " + ConvertMetersToInches(meters).ToString("F2"));
            Console.WriteLine("Inches to Meters : " + ConvertInchesToMeters(inches).ToString("F2"));
            Console.WriteLine("Inches to Centimeters : " + ConvertInchesToCentimeters(inches).ToString("F2"));
        }

        public static double ConvertYardsToFeet(double yards)
        {
            return yards * 3;
        }

        public static double ConvertFeetToYards(double feet)
        {
            return feet * 0.333333;
        }

        public static double ConvertMetersToInches(double meters)
        {
            return meters * 39.3701;
        }

        public static double ConvertInchesToMeters(double inches)
        {
            return inches * 0.0254;
        }

        public static double ConvertInchesToCentimeters(double inches)
        {
            return inches * 2.54;
        }
    }
}