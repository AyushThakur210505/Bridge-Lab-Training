using System;
using System.Collections.Generic;
using System.Text;

namespace Key_words_Level_1_Lab_Practice
{
    internal class Vehicle
    {
        public static double RegistrationFee = 2500;

        public readonly string RegistrationNumber;
        public string OwnerName;
        public string VehicleType;

        public Vehicle(string RegistrationNumber, string OwnerName, string VehicleType)
        {
            this.RegistrationNumber = RegistrationNumber;
            this.OwnerName = OwnerName;
            this.VehicleType = VehicleType;
        }

        public static void UpdateRegistrationFee(double fee)
        {
            RegistrationFee = fee;
        }

        public void Display()
        {
            Console.WriteLine("Registration Number : " + RegistrationNumber);
            Console.WriteLine("Owner Name : " + OwnerName);
            Console.WriteLine("Vehicle Type : " + VehicleType);
            Console.WriteLine("Registration Fee : " + RegistrationFee);
        }

        public static void display()
        {
            Vehicle vehicle = new Vehicle("HP12AB1234", "Ayush", "Car");

            UpdateRegistrationFee(3000);

            if (vehicle is Vehicle)
            {
                vehicle.Display();
            }
        }
    }
}
