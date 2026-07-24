using System;
using System.Collections.Generic;
using System.Text;

namespace Programming_Elements_Level_2_Lab_Practice
{
    internal class SwapNumbers
    {
        public static void display()
        {
            Console.Write("Enter First Number: ");
            int numberOne = int.Parse(Console.ReadLine());

            Console.Write("Enter Second Number: ");
            int numberTwo = int.Parse(Console.ReadLine());

            int temp = numberOne;
            numberOne = numberTwo;
            numberTwo = temp;

            Console.WriteLine("The swapped numbers are " +
                              numberOne + " and " + numberTwo);
        }
    }
}
