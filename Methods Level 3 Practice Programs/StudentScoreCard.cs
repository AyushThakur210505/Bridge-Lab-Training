using System;
using System.Collections.Generic;
using System.Text;

namespace Methods_Level_3_Practice_Programs
{
    internal class StudentScoreCard
    {
        public static void display()
        {
            Console.Write("Enter Number of Students : ");
            int students = int.Parse(Console.ReadLine());

            int[,] marks = GenerateMarks(students);
            double[,] result = CalculateResult(marks);

            Console.WriteLine("\nPhy\tChem\tMath\tTotal\tAverage\tPercentage");

            for (int i = 0; i < students; i++)
            {
                Console.WriteLine($"{marks[i, 0]}\t{marks[i, 1]}\t{marks[i, 2]}\t{result[i, 0]}\t{result[i, 1]:F2}\t{result[i, 2]:F2}%");
            }
        }

        public static int[,] GenerateMarks(int students)
        {
            Random random = new Random();
            int[,] marks = new int[students, 3];

            for (int i = 0; i < students; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    marks[i, j] = random.Next(35, 101);
                }
            }

            return marks;
        }

        public static double[,] CalculateResult(int[,] marks)
        {
            int students = marks.GetLength(0);
            double[,] result = new double[students, 3];

            for (int i = 0; i < students; i++)
            {
                int total = marks[i, 0] + marks[i, 1] + marks[i, 2];
                double average = Math.Round((double)total / 3, 2);
                double percentage = Math.Round((double)total / 300 * 100, 2);

                result[i, 0] = total;
                result[i, 1] = average;
                result[i, 2] = percentage;
            }

            return result;
        }
    }
}
