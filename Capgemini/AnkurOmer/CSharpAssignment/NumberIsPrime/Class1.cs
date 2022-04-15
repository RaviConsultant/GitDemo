using System;

namespace NumberIsPrime
{
    public class CheckPrime
    {
        public void isPrime(int number)
        {
            int i, flg = 0, m = 0;
            m = number / 2;
            for (i = 2; i <= m; i++)
            {
                if (number % i == 0)
                {
                    flg = 1;
                    break;
                }
            }
            if (flg == 0)
            {
                Console.Write("{0},", number);
            }
        }
    }
}
