using System;
using System.Collections.Generic;
using System.Text;

namespace String_Practice_Problems
{
    internal class PalindromeString
    {
        public static void display()
        {
            Console.Write("Enter a String : ");
            string text = Console.ReadLine();

            if (IsPalindrome(text))
                Console.WriteLine("The String is a Palindrome.");
            else
                Console.WriteLine("The String is Not a Palindrome.");
        }

        public static bool IsPalindrome(string text)
        {
            int start = 0;
            int end = text.Length - 1;

            while (start < end)
            {
                if (char.ToLower(text[start]) != char.ToLower(text[end]))
                    return false;

                start++;
                end--;
            }

            return true;
        }
    }
}
