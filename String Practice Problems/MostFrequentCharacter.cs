using System;
using System.Collections.Generic;
using System.Text;

namespace String_Practice_Problems
{
    internal class MostFrequentCharacter
    {
        public static void display()
        {
            Console.Write("Enter a String : ");
            string text = Console.ReadLine();

            char result = FindMostFrequentCharacter(text);

            Console.WriteLine("Most Frequent Character : " + result);
        }

        public static char FindMostFrequentCharacter(string text)
        {
            int maxCount = 0;
            char frequentChar = '\0';

            foreach (char ch in text)
            {
                if (ch == ' ')
                    continue;

                int count = 0;

                foreach (char c in text)
                {
                    if (char.ToLower(ch) == char.ToLower(c))
                        count++;
                }

                if (count > maxCount)
                {
                    maxCount = count;
                    frequentChar = ch;
                }
            }

            return frequentChar;
        }
    }
}