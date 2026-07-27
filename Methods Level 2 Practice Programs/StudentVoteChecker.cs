using System;
using System.Collections.Generic;
using System.Text;

namespace Methods_Level_2_Practice_Programs
{
    internal class StudentVoteChecker
    {
        public static void display()
        {
            int[] ages = new int[10];

            for (int i = 0; i < ages.Length; i++)
            {
                Console.Write($"Enter Age of Student {i + 1} : ");
                ages[i] = int.Parse(Console.ReadLine());

                if (CanStudentVote(ages[i]))
                    Console.WriteLine("Eligible to Vote");
                else
                    Console.WriteLine("Not Eligible to Vote");
            }
        }

        public static bool CanStudentVote(int age)
        {
            if (age < 0)
                return false;

            return age >= 18;
        }
    }
}