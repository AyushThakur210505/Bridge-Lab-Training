using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    internal class MultiplicationTable
    {
        public static void display()
        {
            Console.Write("Enter a Number : ");
            int num = int.Parse(Console.ReadLine());
            int[] table = new int[10];
            for(int i = 0; i < table.Length; i++)
            {
                table[i] = num * (i + 1);
            }
            for(int i = 0; i < table.Length; i++)
            {
                Console.WriteLine($"{num} * {i + 1} : {table[i]}");
            }
        }
    }
}
