using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Lab_Practice
{
    class Appliance
    {
        public virtual void Start()
        {
            Console.WriteLine("Appliance started.");
        }
    }

    class WashingMachine : Appliance
    {
        public override void Start()
        {
            Console.WriteLine("Washing machine started.");
        }
    }

    public class ShallowHierarchy
    {
        public static void Run()
        {
            Console.WriteLine("=== Shallow Inheritance Hierarchy ===");

            WashingMachine machine = new WashingMachine();
            machine.Start();
        }
    }
}
