using System;
using System.Collections.Generic;
using System.Text;

namespace Methods_Level_1_Practice_Programs
{
    internal class MaximumHandshakes
    {
        public static void display()
        {
            Console.Write("Enter a Number : ");
            int num = int.Parse(Console.ReadLine());
            MaximumHandshakes obj = new MaximumHandshakes();
            int handshake = obj.handshakes(num);
            Console.WriteLine($"Maximum number of handshakes among {num} number of students is {handshake}");

        }
        int handshakes(int num)
        {
            return (num * (num - 1)) / 2;
        }
    }
}
