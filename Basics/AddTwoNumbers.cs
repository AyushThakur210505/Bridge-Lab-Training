using System;
using System.Collections.Generic;
using System.Text;

namespace Basics
{
    internal class AddTwoNumbers
    {
        public static void display()
        {
            Console.Write("Enter First Number: ");
            double numberOne = double.Parse(Console.ReadLine());

            Console.Write("Enter Second Number: ");
            double numberTwo = double.Parse(Console.ReadLine());

            double sum = numberOne + numberTwo;

            Console.WriteLine("Sum = " + sum);
        }
    }
}
