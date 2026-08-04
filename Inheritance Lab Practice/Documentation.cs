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

    class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Cat says Meow.");
        }
    }

    public class Documentation
    {
        public static void Run()
        {
            Console.WriteLine("=== Documentation ===");

            Animal animal = new Cat();
            animal.Speak();
        }
    }
}
