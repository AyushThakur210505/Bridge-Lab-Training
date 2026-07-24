using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    internal class FizzBuzzArray
    {
        public static void display()
        {
            Console.Write("Enter a Positive Number: ");
            int number = int.Parse(Console.ReadLine());

            if (number <= 0)
            {
                Console.WriteLine("Invalid Input");
                return;
            }

            string[] result = new string[number + 1];

            for (int i = 1; i <= number; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    result[i] = "FizzBuzz";
                else if (i % 3 == 0)
                    result[i] = "Fizz";
                else if (i % 5 == 0)
                    result[i] = "Buzz";
                else
                    result[i] = i.ToString();
            }

            Console.WriteLine("FizzBuzz Output:");

            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine("Position " + i + " = " + result[i]);
            }
        }
    }
}
