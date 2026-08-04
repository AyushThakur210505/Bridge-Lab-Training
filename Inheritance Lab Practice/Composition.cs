using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Lab_Practice
{
    class Engine
    {
        public void Start()
        {
            Console.WriteLine("Engine started.");
        }
    }
    class Car
    {
        private Engine engine = new Engine();

        public void Drive()
        {
            engine.Start();
            Console.WriteLine("Car is moving.");
        }
    }

    public class Composition
    {
        public static void Run()
        {
            Console.WriteLine("=== Composition Example ===");

            Car car = new Car();
            car.Drive();
        }
    }
}
