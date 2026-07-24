using System;
using System.Collections.Generic;
using System.Text;

namespace Programming_Elements_Level_2_Lab_Practice
{
    internal class IntOperation
    {
        public static void display()
        {
            Console.Write("Enter First Number: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter Second Number: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Enter Third Number: ");
            int c = int.Parse(Console.ReadLine());

            int result1 = a + b * c;
            int result2 = a * b + c;
            int result3 = c + a / b;
            int result4 = a % b + c;

            Console.WriteLine("a + b * c = " + result1);
            Console.WriteLine("a * b + c = " + result2);
            Console.WriteLine("c + a / b = " + result3);
            Console.WriteLine("a % b + c = " + result4);
        }
    }
}