using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation__Polymorphism__Interface_and_Abstract_Class_Practice_problem
{
    interface IGPS
    {
        void GetCurrentLocation();
        void UpdateLocation(string location);
    }

    abstract class Vehicle
    {
        private int vehicleId;
        private string driverName;
        private double ratePerKm;

        public int VehicleId
        {
            get { return vehicleId; }
            set { vehicleId = value; }
        }

        public string DriverName
        {
            get { return driverName; }
            set { driverName = value; }
        }

        public double RatePerKm
        {
            get { return ratePerKm; }
            set { ratePerKm = value; }
        }

        public Vehicle(int id, string driver, double rate)
        {
            VehicleId = id;
            DriverName = driver;
            RatePerKm = rate;
        }

        public abstract double CalculateFare(double distance);

        public void GetVehicleDetails()
        {
            Console.WriteLine("Vehicle ID : " + VehicleId);
            Console.WriteLine("Driver     : " + DriverName);
            Console.WriteLine("Rate/Km    : " + RatePerKm);
        }
    }

    class Car : Vehicle, IGPS
    {
        private string location;

        public Car(int id, string driver, double rate)
            : base(id, driver, rate)
        {
        }

        public override double CalculateFare(double distance)
        {
            return distance * RatePerKm;
        }

        public void GetCurrentLocation()
        {
            Console.WriteLine("Location : " + location);
        }

        public void UpdateLocation(string location)
        {
            this.location = location;
        }
    }

    class Bike : Vehicle, IGPS
    {
        private string location;

        public Bike(int id, string driver, double rate)
            : base(id, driver, rate)
        {
        }

        public override double CalculateFare(double distance)
        {
            return distance * RatePerKm;
        }

        public void GetCurrentLocation()
        {
            Console.WriteLine("Location : " + location);
        }

        public void UpdateLocation(string location)
        {
            this.location = location;
        }
    }

    class Auto : Vehicle, IGPS
    {
        private string location;

        public Auto(int id, string driver, double rate)
            : base(id, driver, rate)
        {
        }

        public override double CalculateFare(double distance)
        {
            return distance * RatePerKm;
        }

        public void GetCurrentLocation()
        {
            Console.WriteLine("Location : " + location);
        }

        public void UpdateLocation(string location)
        {
            this.location = location;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            Car car = new Car(1, "Ali", 18);
            car.UpdateLocation("Lahore");

            Bike bike = new Bike(2, "Sara", 10);
            bike.UpdateLocation("Islamabad");

            Auto auto = new Auto(3, "Ahmed", 14);
            auto.UpdateLocation("Karachi");

            vehicles.Add(car);
            vehicles.Add(bike);
            vehicles.Add(auto);

            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.GetVehicleDetails();
                Console.WriteLine("Fare for 15 Km : " + vehicle.CalculateFare(15));

                if (vehicle is IGPS gps)
                {
                    gps.GetCurrentLocation();
                }

                Console.WriteLine("----------------------------");
            }

            Console.ReadKey();
        }
    }
}
