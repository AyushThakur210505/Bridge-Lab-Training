using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation__Polymorphism__Interface_and_Abstract_Class_Practice_problem
{
    interface IDiscountable
    {
        double ApplyDiscount();
        void GetDiscountDetails();
    }

    abstract class FoodItem
    {
        private string itemName;
        private double price;
        private int quantity;

        public string ItemName
        {
            get { return itemName; }
            set { itemName = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public FoodItem(string name, double price, int quantity)
        {
            ItemName = name;
            Price = price;
            Quantity = quantity;
        }

        public abstract double CalculateTotalPrice();

        public void GetItemDetails()
        {
            Console.WriteLine("Item     : " + ItemName);
            Console.WriteLine("Price    : " + Price);
            Console.WriteLine("Quantity : " + Quantity);
        }
    }

    class VegItem : FoodItem, IDiscountable
    {
        public VegItem(string name, double price, int quantity)
            : base(name, price, quantity)
        {
        }

        public override double CalculateTotalPrice()
        {
            return (Price * Quantity) + 20;
        }

        public double ApplyDiscount()
        {
            return 50;
        }

        public void GetDiscountDetails()
        {
            Console.WriteLine("Discount : Rs.50");
        }
    }

    class NonVegItem : FoodItem, IDiscountable
    {
        public NonVegItem(string name, double price, int quantity)
            : base(name, price, quantity)
        {
        }

        public override double CalculateTotalPrice()
        {
            return (Price * Quantity) + 50;
        }

        public double ApplyDiscount()
        {
            return 30;
        }

        public void GetDiscountDetails()
        {
            Console.WriteLine("Discount : Rs.30");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<FoodItem> foods = new List<FoodItem>();

            foods.Add(new VegItem("Paneer Pizza", 250, 2));
            foods.Add(new NonVegItem("Chicken Burger", 180, 3));

            foreach (FoodItem food in foods)
            {
                food.GetItemDetails();

                double total = food.CalculateTotalPrice();

                if (food is IDiscountable discount)
                {
                    discount.GetDiscountDetails();
                    total -= discount.ApplyDiscount();
                }

                Console.WriteLine("Total Price : " + total);
                Console.WriteLine("---------------------------");
            }

            Console.ReadKey();
        }
    }
}
