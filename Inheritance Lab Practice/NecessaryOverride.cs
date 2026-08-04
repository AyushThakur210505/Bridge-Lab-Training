using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Lab_Practice
{
    class Vehicle
    {
        public virtual void Start()
        {
            Console.WriteLine("Vehicle started.");
        }
    }

    class Bike : Vehicle
    {
    }

    class Car : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("Car started with key.");
        }
    }

    public class NecessaryOverride
    {
        public static void Run()
        {
            Console.WriteLine("=== Necessary Override ===");

            Bike bike = new Bike();
            Car car = new Car();

            bike.Start();
            car.Start();
        }
    }
}
