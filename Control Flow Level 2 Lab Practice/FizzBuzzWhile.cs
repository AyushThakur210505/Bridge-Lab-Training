using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Flow_Level_2_Lab_Practice
{
    internal class FizzBuzzWhile
    {
        public static void display()
        {
            Console.Write("Enter a number : ");
            int num = int.Parse(Console.ReadLine());

            if (num < 0)
            {
                Console.WriteLine("The Number is not positive");
            }
            else
            {
                int i = 0;
                while(i<=num)
                {
                    if (i % 3 != 0 && i % 5 != 0 || i == 0)
                    {
                        Console.WriteLine(i);
                        i++;
                    }
                    else if (i % 3 == 0)
                    {
                        Console.WriteLine("Fizz");
                        i++;
                    }
                    else if (i % 5 == 0)
                    {
                        Console.WriteLine("Buzz");
                        i++;
                    }
                    else
                    {
                        Console.WriteLine("Buzz");
                        i++;
                    }
                }
            }
        }
    }
}
