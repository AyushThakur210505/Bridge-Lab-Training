using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Lab_Practice
{
    abstract class Animal
    {
        public abstract void Speak();
    }

    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Dog barks.");
        }
    }

    public class AbstractVsConcrete
    {
        public static void Run()
        {
            Console.WriteLine("=== Abstract vs Concrete ===");

            Animal animal = new Dog();
            animal.Speak();
        }
    }
}
