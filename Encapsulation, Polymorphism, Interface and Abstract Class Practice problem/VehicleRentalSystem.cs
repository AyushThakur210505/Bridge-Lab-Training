using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation__Polymorphism__Interface_and_Abstract_Class_Practice_problem
{
    interface IInsurable
    {
        double CalculateInsurance();
        void GetInsuranceDetails();
    }

    abstract class Vehicle
    {
        private string vehicleNumber;
        private string type;
        private double rentalRate;

        public string VehicleNumber
        {
            get { return vehicleNumber; }
            set { vehicleNumber = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public double RentalRate
        {
            get { return rentalRate; }
            set { rentalRate = value; }
        }

        private string insurancePolicyNumber;

        public string InsurancePolicyNumber
        {
            set { insurancePolicyNumber = value; }
        }

        public Vehicle(string number, string type, double rate)
        {
            VehicleNumber = number;
            Type = type;
            RentalRate = rate;
        }

        public abstract double CalculateRentalCost(int days);

        public void DisplayDetails()
        {
            Console.WriteLine("Vehicle Number : " + VehicleNumber);
            Console.WriteLine("Type           : " + Type);
        }
    }

    class Car : Vehicle, IInsurable
    {
        public Car(string number, double rate)
            : base(number, "Car", rate)
        {
        }

        public override double CalculateRentalCost(int days)
        {
            return RentalRate * days;
        }

        public double CalculateInsurance()
        {
            return 500;
        }

        public void GetInsuranceDetails()
        {
            Console.WriteLine("Insurance : Rs.500");
        }
    }

    class Bike : Vehicle, IInsurable
    {
        public Bike(string number, double rate)
            : base(number, "Bike", rate)
        {
        }

        public override double CalculateRentalCost(int days)
        {
            return RentalRate * days;
        }

        public double CalculateInsurance()
        {
            return 200;
        }

        public void GetInsuranceDetails()
        {
            Console.WriteLine("Insurance : Rs.200");
        }
    }

    class Truck : Vehicle, IInsurable
    {
        public Truck(string number, double rate)
            : base(number, "Truck", rate)
        {
        }

        public override double CalculateRentalCost(int days)
        {
            return RentalRate * days;
        }

        public double CalculateInsurance()
        {
            return 1000;
        }

        public void GetInsuranceDetails()
        {
            Console.WriteLine("Insurance : Rs.1000");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            vehicles.Add(new Car("PB10A1234", 1500));
            vehicles.Add(new Bike("PB10B5678", 500));
            vehicles.Add(new Truck("PB10C9999", 3000));

            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.DisplayDetails();

                Console.WriteLine("Rental Cost : " + vehicle.CalculateRentalCost(5));

                if (vehicle is IInsurable insurance)
                {
                    insurance.GetInsuranceDetails();
                    Console.WriteLine("Insurance Cost : " + insurance.CalculateInsurance());
                }

                Console.WriteLine("----------------------------");
            }

            Console.ReadKey();
        }
    }
}
