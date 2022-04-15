// Program no.3   Print first N prime numbers

using System;

namespace Capgemini
{
    internal class Program
    {

        public bool IsPrime(int inp)  //Creating a object
        {

            int i;
            int a = 0;

            for (i = 2; (i * i) <= inp; i++)
            {
                if ((inp % i) == 0)
                {

                    a = 1;

                    return false;


                }
            }

            if (a == 0)
            {
                return true; ;
            }
            return false;

        }


        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number(Positive) ");
            int input = Convert.ToInt32(Console.ReadLine());
            int i;
            Program prime = new Program();

            for (i = 2; i < input; i++)
            {

                if (prime.IsPrime(i))
                {
                    Console.WriteLine(i);

                }


            }




        }
    }
}
