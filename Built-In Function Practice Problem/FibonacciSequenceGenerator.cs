using System;
using System.Collections.Generic;
using System.Text;

namespace Built_In_Function_Practice_Problem
{
    internal class FibonacciSequenceGenerator
    {
        public static void display()
        {
            int terms = GetTerms();

            Console.WriteLine("Fibonacci Sequence:");
            PrintFibonacci(terms);
        }

        public static int GetTerms()
        {
            Console.Write("Enter Number of Terms: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        public static void PrintFibonacci(int terms)
        {
            int first = 0;
            int second = 1;

            for (int i = 1; i <= terms; i++)
            {
                Console.Write(first + " ");

                int next = first + second;
                first = second;
                second = next;
            }

            Console.WriteLine();
        }
    }
}
