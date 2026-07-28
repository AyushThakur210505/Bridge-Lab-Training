using System;
using System.Collections.Generic;
using System.Text;

namespace String_Practice_Problems
{
    internal class AnagramChecker
    {
        public static void display()
        {
            Console.Write("Enter First String : ");
            string str1 = Console.ReadLine().ToLower();

            Console.Write("Enter Second String : ");
            string str2 = Console.ReadLine().ToLower();

            if (IsAnagram(str1, str2))
                Console.WriteLine("The strings are Anagrams.");
            else
                Console.WriteLine("The strings are Not Anagrams.");
        }

        public static bool IsAnagram(string str1, string str2)
        {
            str1 = str1.Replace(" ", "");
            str2 = str2.Replace(" ", "");

            if (str1.Length != str2.Length)
                return false;

            char[] arr1 = str1.ToCharArray();
            char[] arr2 = str2.ToCharArray();

            Array.Sort(arr1);
            Array.Sort(arr2);

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                    return false;
            }

            return true;
        }
    }
}
