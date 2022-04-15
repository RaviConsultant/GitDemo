using System;

namespace SumOfDigits
{
    public class SOD
    {
        public int SumOfDigits(int Digits)
        {
            int sum = 0;
            while (Digits > 0)
            {
                sum = sum + (Digits % 10);
                Digits = Digits / 10;
            }

            return sum;
        }
    }
}
