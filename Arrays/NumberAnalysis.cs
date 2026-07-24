using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    internal class NumberAnalysis
    {
        public static void display()
        {
            int[] num = new int[5];
            Console.WriteLine("Enter 5 Numbers");
            for(int i = 0; i < num.Length; i++)
            {
                Console.Write($"Number {i + 1} : ");
                num[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Result : ");
            for(int i = 0; i < num.Length; i++)
            {
                if (num[i] == 0)
                {
                    Console.WriteLine($"Number {i + 1} is : Zero");
                }
                else if (num[i] < 0)
                {
                    Console.WriteLine($"Number {i + 1} is : Negative");
                }
                else if (num[i]>0 && num[i]%2 ==0 )
                {
                    Console.WriteLine($"Number {i + 1} is : Positive and even");
                }
                else
                {
                    Console.WriteLine($"Number {i + 1} is : Positive and odd");
                }
            }
            if (num[0] == num[num.Length - 1])
            {
                Console.WriteLine($"Both no are Equal");
            }
            else if (num[0] > num[num.Length - 1])
            {
                Console.WriteLine($"The first no is greater");
            }
            else
            {
                Console.WriteLine($"The first no is smaller");
            }
        }
    }
}
