using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Sorting_Algorithm
{
    internal class StudentMarks
    {
        public void bubblesort(List<int> list)
        {
            int n = list.Count;
            for(int i = 0; i < n-1; i++)
            {
                for(int j = 0; j < n-1-i; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        int temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }
        }
        public void display(List<int> list)
        {
            Console.WriteLine(String.Join(", ", list));
        }
        public void run()
        {
            Console.WriteLine("Enter the marks of student and Enter -1 to stop");
            List<int> marklist = new List<int>();
            while (true)
            {
                Console.Write("Enter mark of student : ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int mark))
                {
                    if (mark == -1)
                    {
                        break;
                    }
                    if (mark < 0)
                    {
                        Console.WriteLine("Marks cannot be negative");
                        continue;
                    }
                    marklist.Add(mark);
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
            display(marklist);
            bubblesort(marklist);
            display(marklist);
        }
    }
}
