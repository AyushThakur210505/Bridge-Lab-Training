using System;
using System.Collections.Generic;
using System.Text;

namespace Unit_Test_Examples
{
    public class PrimeNo
    {
        public bool IsPrime(int number)
        {
            if (number <= 1)
                return false;
            //Console.WriteLine(false);

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
                    //Console.WriteLine(false);
                }

            return true;
            //Console.WriteLine(true);
        }
    }
}
