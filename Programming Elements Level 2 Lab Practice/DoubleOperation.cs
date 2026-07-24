using System;
using System.Collections.Generic;
using System.Text;
namespace Programming_Elements_Level_2_Lab_Practice
{
    internal class DoubleOperation
    {
        public static void display()
        {
            Console.Write("Enter First Number: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Enter Second Number: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Enter Third Number: ");
            double c = double.Parse(Console.ReadLine());

            double result1 = a + b * c;
            double result2 = a * b + c;
            double result3 = c + a / b;
            double result4 = a % b + c;

            Console.WriteLine("a + b * c = " + result1);
            Console.WriteLine("a * b + c = " + result2);
            Console.WriteLine("c + a / b = " + result3);
            Console.WriteLine("a % b + c = " + result4);
        }
    }
}
