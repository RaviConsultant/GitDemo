using System;

namespace first_n_prime_no
{
    internal class Program
    {
        //print prime between 1 to given number

        /// <summary>
        /// method to check no is prime or not
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static bool isPrime(int n)
        {
            //since 0 and 1 is not prime return false.
            if (n == 1 || n == 0)
            {
                return false;
            }
            //Run a loop from 2 to n-1
            for (int i = 2; i < n; i++)
            {
                // if the number is divisible by i, then n is not a prime number.
                if (n % i == 0)
                {
                    return false;
                }
            }
            //otherwise, n is prime number.
            return true;
        }

        public static void Main(String[] args)
        {
            Console.WriteLine("Enter the number :");

            try
            {
                int num = Convert.ToInt32(Console.ReadLine());
                //check for every number from 1 to N
                for (int i = 1; i <= num; i++)
                {
                    //check if current number is prime
                    if (isPrime(i))
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            // if any exception occur
            catch(Exception ex)
            {
                Console.WriteLine("plese enter a integer no");
            }
            

        }


        //first n no. of prime no. that is given
        //static void Main(string[] args)
        //{ 

        //    //#region for first n no of prime no 
        //    //int n = int.Parse(Console.ReadLine());
        //    //int primecount = 0;
        //    //int i = 2;
        //      // finction for checking prime number
        //    //while (counter < n)
        //    //{
        //   //    bool isPrime = true;
        //    //    for (int j = 2; j < i; j++)
        //    //    {
        //    //        if (i % j == 0)
        //    //        {
        //    //            isPrime = false;
        //    //        }
        //    //    }
        //    //    if (isPrime)
        //    //    {
        //    //        ++counter;
        //    //        Console.WriteLine(i);
        //    //    }
        //    //    ++i;
        //    //}
        //    //#endregion for first n no of prime no 

        //}
    }
}
