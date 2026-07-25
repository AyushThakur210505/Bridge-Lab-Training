using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Flow_Level_2_Lab_Practice
{
    internal class FizzBuzzFor
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
                for(int i = 0; i <= num; i++)
                {
                    if(i % 3 != 0 && i % 5 != 0 || i==0)
                    {
                        Console.WriteLine(i);
                    }
                    else if (i % 3 == 0)
                    {
                        Console.WriteLine("Fizz");
                    }
                    else if (i % 5 == 0)
                    {
                        Console.WriteLine("Buzz");
                    }
                    else
                    {
                        Console.WriteLine("Buzz");
                    }
                }
            }
        }
    }
}
