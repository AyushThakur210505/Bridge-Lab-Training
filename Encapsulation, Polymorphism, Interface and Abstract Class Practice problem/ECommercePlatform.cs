using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation__Polymorphism__Interface_and_Abstract_Class_Practice_problem
{
    interface ITaxable
    {
        double CalculateTax();
        void GetTaxDetails();
    }

    abstract class Product
    {
        private int productId;
        private string name;
        private double price;

        public int ProductId
        {
            get { return productId; }
            set { productId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public Product(int id, string name, double price)
        {
            ProductId = id;
            Name = name;
            Price = price;
        }

        public abstract double CalculateDiscount();
    }

    class Electronics : Product, ITaxable
    {
        public Electronics(int id, string name, double price)
            : base(id, name, price)
        {
        }

        public override double CalculateDiscount()
        {
            return Price * 0.10;
        }

        public double CalculateTax()
        {
            return Price * 0.18;
        }

        public void GetTaxDetails()
        {
            Console.WriteLine("Tax : 18%");
        }
    }

    class Clothing : Product, ITaxable
    {
        public Clothing(int id, string name, double price)
            : base(id, name, price)
        {
        }

        public override double CalculateDiscount()
        {
            return Price * 0.20;
        }

        public double CalculateTax()
        {
            return Price * 0.05;
        }

        public void GetTaxDetails()
        {
            Console.WriteLine("Tax : 5%");
        }
    }

    class Groceries : Product
    {
        public Groceries(int id, string name, double price)
            : base(id, name, price)
        {
        }

        public override double CalculateDiscount()
        {
            return Price * 0.05;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            products.Add(new Electronics(101, "Laptop", 60000));
            products.Add(new Clothing(102, "T-Shirt", 2000));
            products.Add(new Groceries(103, "Rice", 1000));

            foreach (Product product in products)
            {
                Console.WriteLine("Product ID : " + product.ProductId);
                Console.WriteLine("Product Name : " + product.Name);
                Console.WriteLine("Price : " + product.Price);

                double discount = product.CalculateDiscount();
                double tax = 0;

                if (product is ITaxable taxable)
                {
                    tax = taxable.CalculateTax();
                    taxable.GetTaxDetails();
                }

                double finalPrice = product.Price + tax - discount;

                Console.WriteLine("Discount : " + discount);
                Console.WriteLine("Tax Amount : " + tax);
                Console.WriteLine("Final Price : " + finalPrice);

                Console.WriteLine("----------------------------");
            }

            Console.ReadKey();
        }
    }
}
