using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Lab_Practice
{
    class Bird
    {
        public virtual void Move()
        {
            Console.WriteLine("Bird is moving.");
        }
    }

    class Sparrow : Bird
    {
        public override void Move()
        {
            Console.WriteLine("Sparrow is flying.");
        }
    }

    public class LiskovSubstitution
    {
        public static void Run()
        {
            Console.WriteLine("=== Liskov Substitution Principle ===");

            Bird bird = new Sparrow();
            bird.Move();
        }
    }
}
