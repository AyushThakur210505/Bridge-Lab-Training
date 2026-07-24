using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    internal class StudentVotingEligibility
    {
        public static void display()
        {
            int[] age = new int[10];
            Console.WriteLine("Enter the age of 10 students : ");
            for(int i = 0; i < age.Length; i++)
            {
                Console.Write($"Student {i + 1} : ");
                age[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Result : ");
            for(int i = 0; i < age.Length; i++)
            {
                if (age[i] < 0)
                {
                    Console.WriteLine($"Student {i} have Invalid Age");
                }
                else if (age[i] < 18)
                {
                    Console.WriteLine($"The student {i} with age {age[i]} cannot vote");
                }
                else
                {
                    Console.WriteLine($"The Student with the age {age[i]} can vote");
                }
            }
        }
    }
}
