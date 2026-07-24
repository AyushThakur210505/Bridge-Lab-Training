using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    internal class ArraySumCalculator
    {
        public static void display()
        {
            double[] number = new double[10];
            double total = 0.0;
            int index = 0;
            while (true)
            {
                Console.Write("Enter a number : ");
                double num = double.Parse(Console.ReadLine());
                if (num <= 0)
                {
                    break;
                }
                if(index == number.Length)
                {
                    Console.WriteLine("Array Is Full");
                    break;
                }
                number[index] = num;
                index++;
            }
            Console.WriteLine("Numbers Entered : ");
            for(int i = 0; i < index; i++)
            {
                Console.WriteLine(number[i]);
                total += number[i];
            }
            Console.WriteLine($"Total Value : {total:F2}");
        }
    }
}
