using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    internal class MultiplicationTableSixToNine
    {
        public static void display()
        {
            Console.Write("Enter a Number : ");
            int num = int.Parse(Console.ReadLine());
            int[] teams = new int[4];
            for(int i = 6; i <= 9; i++)
            {
                teams[i - 6] = num * i;
            }
            Console.WriteLine("Multiplication Table 6 to 9");
            for(int i = 6; i <= 9; i++)
            {
                Console.WriteLine($"{num} * {i} = {teams[i - 6]}");
            }
        }
    }
}
