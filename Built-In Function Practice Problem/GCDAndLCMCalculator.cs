using System;
using System.Collections.Generic;
using System.Text;

namespace Built_In_Function_Practice_Problem
{
    internal class GCDAndLCMCalculator
    {
        public static void display()
        {
            int num1 = GetNumber("Enter First Number: ");
            int num2 = GetNumber("Enter Second Number: ");

            int gcd = FindGCD(num1, num2);
            int lcm = FindLCM(num1, num2);

            Console.WriteLine("GCD = " + gcd);
            Console.WriteLine("LCM = " + lcm);
        }

        public static int GetNumber(string message)
        {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        }

        public static int FindGCD(int num1, int num2)
        {
            while (num2 != 0)
            {
                int temp = num2;
                num2 = num1 % num2;
                num1 = temp;
            }

            return num1;
        }

        public static int FindLCM(int num1, int num2)
        {
            return (num1 * num2) / FindGCD(num1, num2);
        }
    }
}