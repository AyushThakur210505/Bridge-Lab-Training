using System;
using System.Collections.Generic;
using System.Text;

namespace Key_words_Level_1_Lab_Practice
{
    internal class Product
    {
        public static double Discount = 10;

        public readonly int ProductID;
        public string ProductName;
        public double Price;
        public int Quantity;

        public Product(int ProductID, string ProductName, double Price, int Quantity)
        {
            this.ProductID = ProductID;
            this.ProductName = ProductName;
            this.Price = Price;
            this.Quantity = Quantity;
        }

        public static void UpdateDiscount(double newDiscount)
        {
            Discount = newDiscount;
        }

        public void Display()
        {
            Console.WriteLine("Product ID : " + ProductID);
            Console.WriteLine("Product Name : " + ProductName);
            Console.WriteLine("Price : " + Price);
            Console.WriteLine("Quantity : " + Quantity);
            Console.WriteLine("Discount : " + Discount + "%");
        }

        public static void display()
        {
            Product product = new Product(501, "Laptop", 65000, 2);

            UpdateDiscount(15);

            if (product is Product)
            {
                product.Display();
            }
        }
    }
}
