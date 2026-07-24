using System;
using System.Collections.Generic;
using System.Text;

namespace Programming_Elements_Level_1_Lab_Practice
{
    internal class ProfitLoss
    {
        public static void display()
        {
            double costPrice = 129;
            double sellingPrice = 191;

            double profit = sellingPrice - costPrice;
            double profitPercentage = (profit / costPrice) * 100;

            Console.WriteLine("The Cost Price is INR " + costPrice + " and Selling Price is INR " + sellingPrice);
            Console.WriteLine("The Profit is INR " + profit + " and the Profit Percentage is " + profitPercentage.ToString("F2") + "%");
        }
    }
}
