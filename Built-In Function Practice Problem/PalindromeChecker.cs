using System;
using System.Collections.Generic;
using System.Text;

namespace Built_In_Function_Practice_Problem
{
    internal class PalindromeChecker
    {
        public static void display()
        {
            string text = GetString();

            if (IsPalindrome(text))
                Console.WriteLine("The string is a Palindrome.");
            else
                Console.WriteLine("The string is Not a Palindrome.");
        }

        public static string GetString()
        {
            Console.Write("Enter a String: ");
            return Console.ReadLine().ToLower();
        }

        public static bool IsPalindrome(string text)
        {
            int start = 0;
            int end = text.Length - 1;

            while (start < end)
            {
                if (text[start] != text[end])
                    return false;

                start++;
                end--;
            }

            return true;
        }
    }
}
