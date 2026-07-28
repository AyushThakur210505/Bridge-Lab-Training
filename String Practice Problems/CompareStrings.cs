using System;
using System.Collections.Generic;
using System.Text;

namespace String_Practice_Problems
{
    internal class CompareStrings
    {
        public static void display()
        {
            Console.Write("Enter First String : ");
            string str1 = Console.ReadLine();

            Console.Write("Enter Second String : ");
            string str2 = Console.ReadLine();

            int result = Compare(str1, str2);

            if (result == 0)
                Console.WriteLine("Both strings are equal.");
            else if (result < 0)
                Console.WriteLine($"\"{str1}\" comes before \"{str2}\".");
            else
                Console.WriteLine($"\"{str1}\" comes after \"{str2}\".");
        }

        public static int Compare(string str1, string str2)
        {
            int length = Math.Min(str1.Length, str2.Length);

            for (int i = 0; i < length; i++)
            {
                if (str1[i] < str2[i])
                    return -1;

                if (str1[i] > str2[i])
                    return 1;
            }

            if (str1.Length < str2.Length)
                return -1;

            if (str1.Length > str2.Length)
                return 1;

            return 0;
        }
    }
}
