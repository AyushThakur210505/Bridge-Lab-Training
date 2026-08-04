using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Lab_Practice
{
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Animal is eating.");
        }
    }
    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Dog is barking.");
        }
    }

    public class IsARelationship
    {
        public static void Run()
        {
            Console.WriteLine("=== Is-A Relationship Example ===");

            Dog dog = new Dog();

            dog.Eat();
            dog.Bark();
        }
    }
}
