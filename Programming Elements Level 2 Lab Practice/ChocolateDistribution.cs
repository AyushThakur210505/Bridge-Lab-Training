using System;
using System.Collections.Generic;
using System.Text;

namespace Programming_Elements_Level_2_Lab_Practice
{
    internal class ChocolateDistribution
    {
        public static void display()
        {
            Console.Write("Enter Number of Chocolates: ");
            int chocolates = int.Parse(Console.ReadLine());

            Console.Write("Enter Number of Children: ");
            int children = int.Parse(Console.ReadLine());

            int chocolatesPerChild = chocolates / children;
            int remainingChocolates = chocolates % children;

            Console.WriteLine("The number of chocolates each child gets is " +
                              chocolatesPerChild +
                              " and the number of remaining chocolates is " +
                              remainingChocolates);
        }
    }
}
