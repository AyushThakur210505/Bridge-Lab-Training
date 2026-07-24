using System;
using System.Collections.Generic;
using System.Text;

namespace Programming_Elements_Level_2_Lab_Practice
{
    internal class SimpleInterest
    {
        public static void display()
        {
            Console.Write("Enter Principal: ");
            double principal = double.Parse(Console.ReadLine());

            Console.Write("Enter Rate: ");
            double rate = double.Parse(Console.ReadLine());

            Console.Write("Enter Time: ");
            double time = double.Parse(Console.ReadLine());

            double simpleInterest = (principal * rate * time) / 100;

            Console.WriteLine("The Simple Interest is " + simpleInterest +
                              " for Principal " + principal +
                              ", Rate of Interest " + rate +
                              " and Time " + time);
        }
    }
}
