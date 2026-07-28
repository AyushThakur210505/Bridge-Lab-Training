using System;
using System.Collections.Generic;
using System.Text;

namespace String_Practice_Problems
{
    internal class RemoveDuplicateCharacters
    {
        public static void display()
        {
            Console.Write("Enter a String : ");
            string text = Console.ReadLine();

            string result = RemoveDuplicates(text);

            Console.WriteLine("String after removing duplicates : " + result);
        }

        public static string RemoveDuplicates(string text)
        {
            string result = "";

            foreach (char ch in text)
            {
                bool found = false;

                foreach (char c in result)
                {
                    if (char.ToLower(ch) == char.ToLower(c))
                    {
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    result += ch;
                }
            }

            return result;
        }
    }
}
