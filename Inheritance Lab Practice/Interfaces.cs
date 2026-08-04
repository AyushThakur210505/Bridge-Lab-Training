using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Lab_Practice
{
    interface IFlyable
    {
        void Fly();
    }

    interface ISwimmable
    {
        void Swim();
    }

    class Duck : IFlyable, ISwimmable
    {
        public void Fly()
        {
            Console.WriteLine("Duck is flying.");
        }

        public void Swim()
        {
            Console.WriteLine("Duck is swimming.");
        }
    }

    public class Interfaces
    {
        public static void Run()
        {
            Console.WriteLine("=== Interfaces ===");

            Duck duck = new Duck();

            duck.Fly();
            duck.Swim();
        }
    }
}