using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting_Algorithm
{
    internal class BookPrices
    {
        public void MergeSort(List<int> list)
        {
           
        }
        public void display(List<int> list)
        {
            Console.WriteLine(String.Join(", ", list));
        }
        public void run()
        {
            Console.WriteLine("Enter the Books price and Enter -1 to stop");
            List<int> prices = new List<int>();
            while (true)
            {
                Console.Write("Enter the Books price : ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int price))
                {
                    if (price == -1)
                    {
                        break;
                    }
                    if (price < 0)
                    {
                        Console.WriteLine("employees IDs cannot be negative");
                        continue;
                    }
                    prices.Add(price);
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
            display(prices);
            MergeSort(prices);
            display(prices);
        }
    }
}
