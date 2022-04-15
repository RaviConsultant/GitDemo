using System;

namespace Assignment
{
    class sum_of_digits
    {
        static int getfact(int n)
        {
            int fact = 1;
            while (n >= 1)
            {

                fact = fact * n;
                n--;
            }
            return fact;
        }

        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(getfact(n));
        }

    }

}