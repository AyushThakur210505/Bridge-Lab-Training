using System;
using System.Collections.Generic;
using System.Text;

namespace Methods_Level_1_Practice_Programs
{
    internal class SimpleInterest
    {
        public static void display()
        {
            Console.Write("Enter Principal amount : ");
            double Pricipal = double.Parse(Console.ReadLine());

            Console.Write("Enter Rate : ");
            double Rate = double.Parse(Console.ReadLine());

            Console.Write("Enter Time in years : ");
            double Time = double.Parse(Console.ReadLine());

            double simple_interest = CalculateSimpleInterest(Pricipal,Rate,Time);

            Console.WriteLine($"The Simple Interest is {simple_interest} for Principal {Pricipal}, Rate of Interest {Rate}% and Time {Time} years.");
        }
        public static double CalculateSimpleInterest(double Principal,double Rate, double Time)
        {
            return ((Principal * Rate * Time) / 100);
        }
    }
}
