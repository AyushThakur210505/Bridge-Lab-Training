using System;
using System.Collections.Generic;
using System.Text;

namespace Basics
{
    internal class AverageOfThreeNumbers
    {
        public static void display()
        {
            Console.Write("Enter First Number: ");
            double numberOne = double.Parse(Console.ReadLine());

            Console.Write("Enter Second Number: ");
            double numberTwo = double.Parse(Console.ReadLine());

            Console.Write("Enter Third Number: ");
            double numberThree = double.Parse(Console.ReadLine());

            double average = (numberOne + numberTwo + numberThree) / 3;

            Console.WriteLine("Average = " + average);
        }
    }
}
