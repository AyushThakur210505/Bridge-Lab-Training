using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace Control_Flow_Level_1_Lab_Practice
{
    internal class NaturalNumberSumWhile
    {
        public static void display()
        {
            Console.Write("Enter a Number : ");
            int num = int.Parse(Console.ReadLine());

            if (num <= 0)
            {
                Console.WriteLine($"The Number {num} is not a natural number");
            }
            Console.WriteLine($"Sum of Natural Number using n*(n+1)/2 is : {(num*(num + 1)) / 2}");

            int Total = 0;
            while (num > 0)
            {
                Console.WriteLine($"Sum of Natural Number using While loop is : {Total} + {num} = {Total + num}");
                Total += num;
                num--;
            }
            Console.WriteLine($"Both the Result are same {Total}");
        }
    }
}
