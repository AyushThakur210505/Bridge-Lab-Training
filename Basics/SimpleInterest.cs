using System;
using System.Collections.Generic;
using System.Text;

namespace Basics
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

            double interest = (principal * rate * time) / 100;

            Console.WriteLine("Simple Interest = " + interest);
        }
    }
}
