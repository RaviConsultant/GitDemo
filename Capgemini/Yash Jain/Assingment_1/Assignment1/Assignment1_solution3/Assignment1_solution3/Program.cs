using System;
using System.Collections.Generic;
namespace Assignment1_solution3
{
    internal class Program
    {
        //This is the solution of question 3
        /// <summary>
        /// This method helps us to cheak our num is prime or not
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static bool isprime(int num)
        {
            int m = num / 2;
            for (int i = 2; i <= m; i++)
            {
                if (num % i == 0)
                {
                    return false;
                    break;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            int m = 0;
            int t = 0;
            while (t == 0)
            {
                Console.Write("Enter your number:- ");
                try
                {
                    int x = Convert.ToInt32(Console.ReadLine());
                    for (int i = 2; i < x; i++)
                    {
                        if (isprime(i))
                        {
                            list.Add(i);
                            m++;
                        }
                        else
                        {
                            continue;
                        }
                    }

                    Console.WriteLine("List of prime numbers:- ");
                    for (int y = 0; y < m; y++)
                    {
                        Console.Write(list[y]);
                        if (y == m - 1)
                        {
                            break;
                        }
                        else
                        {
                            Console.Write(", ");
                        }
                    }
                    t++;
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid Input");
                    Console.WriteLine("Program will run again and again until you give valid input");
                }
            }
        }
    }
}
