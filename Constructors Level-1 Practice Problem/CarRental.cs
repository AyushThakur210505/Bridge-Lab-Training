using System;
using System.Collections.Generic;
using System.Text;

namespace Java_Constructors_Level_1_Practice_Problem
{
    internal class CarRental
    {
        private string customerName;
        private string carModel;
        private int rentalDays;

        public CarRental()
        {
            customerName = "unkown";
            carModel = "unkown";
            rentalDays = 0;

        }

        public CarRental(string customerName, string carModel, int rentalDays)
        {
            this.customerName = customerName;
            this.carModel = carModel;
            this.rentalDays = rentalDays;
        }
        public void display()
        {
            Console.WriteLine($"Dear {customerName}, The cost of {carModel} car for {rentalDays} rental days will be {cost()}");
        }

        double cost()
        {
            return (rentalDays * 5000);
        }
    }
}
