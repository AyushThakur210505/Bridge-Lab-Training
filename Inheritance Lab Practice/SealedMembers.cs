using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Lab_Practice
{
    class Animal
    {
        public virtual void Sound()
        {
            Console.WriteLine("Animal makes a sound.");
        }
    }

    class Dog : Animal
    {
        public sealed override void Sound()
        {
            Console.WriteLine("Dog barks.");
        }
    }

    public class SealedMembers
    {
        public static void Run()
        {
            Console.WriteLine("=== Sealed Members ===");

            Dog dog = new Dog();
            dog.Sound();
        }
    }
}