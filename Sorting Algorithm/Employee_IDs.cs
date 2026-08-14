using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting_Algorithm
{
    internal class Employee_IDs
    {
        public void InsertionSort(List<int> list)
        {
            int n = list.Count;
            for (int i = 1; i < n; i++)
            {
                int key = list[i];
                int j = i - 1;

                while(j>=0 && list[j] > key)
                {
                    list[j + 1] = list[j];
                    j--;
                }
                list[j + 1] = key;

            }
        }
        public void display(List<int> list)
        {
            Console.WriteLine(String.Join(", ", list));
        }
        public void run()
        {
            Console.WriteLine("Enter the employees IDs and Enter -1 to stop");
            List<int> Ids = new List<int>();
            while (true)
            {
                Console.Write("Enter the employees IDs : ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int Id))
                {
                    if (Id == -1)
                    {
                        break;
                    }
                    if (Id < 0)
                    {
                        Console.WriteLine("employees IDs cannot be negative");
                        continue;
                    }
                    Ids.Add(Id);
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
            display(Ids);
            InsertionSort(Ids);
            display(Ids);
        }
    }
}
