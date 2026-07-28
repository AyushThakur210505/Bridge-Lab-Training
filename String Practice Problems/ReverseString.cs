using System;
using System.Collections.Generic;
using System.Text;

namespace String_Practice_Problems
{
    internal class ReverseString
    {
        public static void display()
        {
            Console.Write("Enter a String : ");
            string text = Console.ReadLine();

            string reverse = Reverse(text);

            Console.WriteLine("Reversed String : " + reverse);
        }

        public static string Reverse(string text)
        {
            char[] reverse = new char[text.Length];
            int index = 0;

            for (int i = text.Length - 1; i >= 0; i--)
            {
                reverse[index] = text[i];
                index++;
            }

            return new string(reverse);
        }
    }
}
