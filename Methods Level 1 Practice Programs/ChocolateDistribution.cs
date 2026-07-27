using System;
using System.Collections.Generic;
using System.Text;

namespace Methods_Level_1_Practice_Programs
{
    internal class ChocolateDistribution
    {
        public static void display()
        {
            Console.Write("Enter Number of Chocolates : ");
            int chocolates = int.Parse(Console.ReadLine());

            Console.Write("Enter Number of Children : ");
            int children = int.Parse(Console.ReadLine());

            int[] result = checker(chocolates, children);

            Console.WriteLine("Each Child Gets : " + result[0]);
            Console.WriteLine("Remaining Chocolates : " + result[1]);
        }

        public static int[] checker(int chocolates, int children)
        {
            int eachChildGets = chocolates / children;
            int remaining = chocolates % children;

            return new int[] { eachChildGets, remaining };
        }
    }
}