using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTesting
{
    public class Calculator
    {
        public int Add(int a, int b, int c)
        {
            return a + b+ c;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Divide(int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException();

            return a / b;
        }
    }
}
