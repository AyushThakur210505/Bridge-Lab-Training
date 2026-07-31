using System;
using System.Collections.Generic;
using System.Text;

namespace Java_Instance__Class_Variables_and_Methods_Level_1_Practice_Problem
{
    internal class ProductInventory
    {
        private string productName;
        private double price;
        private static int totalProducts=0;

        public ProductInventory(string productName,double price)
        {
            this.productName = productName;
            this.price = price;
            totalProducts++;
        }
        public void DisplayProductDetails()
        {
            Console.WriteLine("Product Name is : "+productName);
            Console.WriteLine("Product price is : " + price);
        }

        public static void DisplayTotalProducts()
        {
            Console.WriteLine("The Number of products are : " + totalProducts);
        }
    }
}
