using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Lab_Practice
{
    class StaffMember
    {
        protected string StaffName;

        public StaffMember(string staffName)
        {
            StaffName = staffName;
        }
    }

    class DepartmentHead : StaffMember
    {
        public DepartmentHead(string staffName) : base(staffName)
        {
        }

        public void Display()
        {
            Console.WriteLine("Department Head: " + StaffName);
        }
    }

    public class ProtectedMembers
    {
        public static void Run()
        {
            Console.WriteLine("=== Protected Members ===");

            DepartmentHead head = new DepartmentHead("Ali");
            head.Display();
        }
    }
}
