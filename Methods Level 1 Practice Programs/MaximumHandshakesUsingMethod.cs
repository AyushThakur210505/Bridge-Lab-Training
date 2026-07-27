using System;
using System.Collections.Generic;
using System.Text;

namespace Methods_Level_1_Practice_Programs
{
    internal class MaximumHandshakesUsingMethod
    {
        public static void display()
        {
            Console.Write("Enter a Number : ");
            int num = int.Parse(Console.ReadLine());

            int handshake = handshakes(num);
            Console.WriteLine($"Maximum number of handshakes among {num} number of students is {handshake}");

        }
        public static int handshakes(int num)
        {
            return (num * (num - 1)) / 2;
        }
    }
}
