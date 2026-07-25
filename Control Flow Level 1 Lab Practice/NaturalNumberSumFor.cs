using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Flow_Level_1_Lab_Practice
{
    internal class NaturalNumberSumFor
    {
        public static void display()
        {
            Console.Write("Enter a Number : ");
            int num = int.Parse(Console.ReadLine());

            if (num <= 0)
            {
                Console.WriteLine($"The Number {num} is not a natural number");
            }
            Console.WriteLine($"Sum of Natural Number using n*(n+1)/2 is : {(num * (num + 1)) / 2}");

            int Total = 0;
            for(int i=num;i>0;i--)
            {
                Console.WriteLine($"Sum of Natural Number using While loop is : {Total} + {i} = {Total + i}");
                Total += i;
            }
            Console.WriteLine($"Both the Result are same {Total}");
        }
    }
}
