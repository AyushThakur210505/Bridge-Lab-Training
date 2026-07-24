using System;
using System.Collections.Generic;
using System.Text;

namespace Programming_Elements_Level_1_Lab_Practice
{
    internal class BasicCalculator
    {
        public static void display()
        {
            Console.Write("Enter First Number: ");
            double numberOne = double.Parse(Console.ReadLine());

            Console.Write("Enter Second Number: ");
            double numberTwo = double.Parse(Console.ReadLine());

            double addition = numberOne + numberTwo;
            double subtraction = numberOne - numberTwo;
            double multiplication = numberOne * numberTwo;
            double division = numberOne / numberTwo;

            Console.WriteLine("Addition = " + addition);
            Console.WriteLine("Subtraction = " + subtraction);
            Console.WriteLine("Multiplication = " + multiplication);
            Console.WriteLine("Division = " + division);
        }
    }
}
