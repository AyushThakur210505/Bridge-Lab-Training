using System;
using System.Collections.Generic;
using System.Text;

namespace String_Practice_Problems
{
    internal class SubstringOccurrences
    {
        public static void display()
        {
            Console.Write("Enter Main String : ");
            string text = Console.ReadLine();

            Console.Write("Enter Substring : ");
            string sub = Console.ReadLine();

            int count = CountOccurrences(text, sub);

            Console.WriteLine("Occurrences : " + count);
        }

        public static int CountOccurrences(string text, string sub)
        {
            int count = 0;

            for (int i = 0; i <= text.Length - sub.Length; i++)
            {
                bool found = true;

                for (int j = 0; j < sub.Length; j++)
                {
                    if (text[i + j] != sub[j])
                    {
                        found = false;
                        break;
                    }
                }

                if (found)
                    count++;
            }

            return count;
        }
    }
}