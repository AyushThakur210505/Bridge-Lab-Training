using System;
using System.Collections.Generic;
using System.Text;

namespace Methods_Level_1_Practice_Programs
{
    internal class TriangularParkRounds
    {
        public static void display()
        {
            Console.Write("Enter the first side of triangle in meter : ");
            int first_num = int.Parse(Console.ReadLine());

            Console.Write("Enter the second side of triangle in meter : ");
            int second_num = int.Parse(Console.ReadLine());

            Console.Write("Enter the third side of triangle in meter : ");
            int third_num = int.Parse(Console.ReadLine());

            double round = roundss(first_num, second_num, third_num);

            Console.WriteLine($"To cover the distance of 5 km the athlete have to cover {round} rounds");
        }
        public static double roundss(double first_num,double second_num,double third_num)
        {
            return ((first_num + second_num + third_num) / 5000);
        }
    }
}
