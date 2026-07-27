using System;
using System.Collections.Generic;
using System.Text;

namespace Methods_Level_3_Practice_Programs
{
    internal class OTPGenerator
    {
        public static void display()
        {
            int[] otpArray = new int[10];

            for (int i = 0; i < otpArray.Length; i++)
            {
                otpArray[i] = GenerateOTP();
            }

            Console.WriteLine("Generated OTPs:");

            foreach (int otp in otpArray)
            {
                Console.WriteLine(otp);
            }

            if (AreUnique(otpArray))
                Console.WriteLine("\nAll OTPs are Unique.");
            else
                Console.WriteLine("\nDuplicate OTP Found.");
        }

        public static int GenerateOTP()
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            return random.Next(100000, 1000000);
        }

        public static bool AreUnique(int[] otpArray)
        {
            for (int i = 0; i < otpArray.Length; i++)
            {
                for (int j = i + 1; j < otpArray.Length; j++)
                {
                    if (otpArray[i] == otpArray[j])
                        return false;
                }
            }

            return true;
        }
    }
}