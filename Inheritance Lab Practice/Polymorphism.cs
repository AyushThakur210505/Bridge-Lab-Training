using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Lab_Practice
{
    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("Animal makes a sound.");
        }
    }

    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Dog barks.");
        }
    }

    class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Cat meows.");
        }
    }

    public class Polymorphism
    {
        public static void Run()
        {
            Console.WriteLine("=== Polymorphism ===");

            Animal animal;

            animal = new Dog();
            animal.Speak();

            animal = new Cat();
            animal.Speak();
        }
    }
}
