using System;
using System.Collections.Generic;
using System.Text;

namespace Programming_Elements_Level_2_Lab_Practice
{
    internal class QuotientRemainder
    {
        public static void display()
        {
            Console.Write("Enter First Number: ");
            int numberOne = int.Parse(Console.ReadLine());

            Console.Write("Enter Second Number: ");
            int numberTwo = int.Parse(Console.ReadLine());

            int quotient = numberOne / numberTwo;
            int remainder = numberOne % numberTwo;

            Console.WriteLine("The Quotient is " + quotient +
                              " and Remainder is " + remainder +
                              " of two numbers " + numberOne +
                              " and " + numberTwo);
        }
    }
}
