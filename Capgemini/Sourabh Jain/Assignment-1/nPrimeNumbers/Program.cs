using System;

namespace nPrimeNumbers
{
    internal class Program
    {
        public bool IsPrime(int j)
        {
            //int i = 2;
            for (int i = 2; i < j; i++)
            {
                if (j % i == 0)
                {
                    return false;
                }
                //return true;
            }
            return true;
        }
        public void Prime(int n)
        {
            if (n == 0)
            {
                return;
            }
            else
            {
                for (int i = 2; i <= n; i++)
                {
                    if (IsPrime(i))
                    {
                        Console.WriteLine(i + " ");

                    }
                }

            }
        }
        public static void Main()
        {
            int num;
            Console.WriteLine("Enter a Number");
            num = int.Parse(Console.ReadLine());
            Program p = new Program();
            if (num > 0)
            {
                Console.WriteLine("prime numbers till " + num + " are: " + "\n---------------");
                p.Prime(num);
            }
            while (num <= 0)
            {
                Console.WriteLine("Enter valid number");
                num = int.Parse(Console.ReadLine());
                Console.WriteLine("prime numbers till" + num + " are: " + "\n---------------");
                p.Prime(num);
            }
        }
    }
}
