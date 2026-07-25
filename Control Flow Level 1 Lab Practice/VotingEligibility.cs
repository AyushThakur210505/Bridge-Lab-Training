using System;
using System.Collections.Generic;
using System.Text;

namespace Control_Flow_Level_1_Lab_Practice
{
    internal class VotingEligibility
    {
        public static void display()
        {
            Console.Write("Emter Your Age : ");
            int age = int.Parse(Console.ReadLine());

            if (age <= 0)
            {
                Console.WriteLine($"The person's age is Invalid");
            }
            else if (age < 18)
            {
                Console.WriteLine($"The person's age is {age} and cannot vote");
            }
            else
            {
                Console.WriteLine($"The person's age is {age} and can vote");
            }
        }
    }
}
