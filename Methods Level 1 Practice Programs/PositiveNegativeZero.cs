using System;
using System.Collections.Generic;
using System.Text;

namespace Methods_Level_1_Practice_Programs
{
    internal class PositiveNegativeZero
    {
        public static void display()
        {
            Console.Write("Enter a number : ");
            int num = int.Parse(Console.ReadLine());

            int result = checker(num);
            Console.WriteLine(result);
        }
        public static int checker(int num)
        {
            if (num < 0)
            {
                return -1;
            }
            else if(num == 0)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}
