using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Que_3_Print_prime_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, i = 3, count, c;

            Console.WriteLine("Please enter the number of prime numbers");
            num = Convert.ToInt32(Console.ReadLine());

            if (num >= 1)
            {

                Console.WriteLine("First " + num + " Prime Numbers are :\n");
                Console.WriteLine("2");
            }

            for (count = 2; count <= num;)
            {
                for (c = 2; c <= i - 1; c++)
                {
                    if (i % c == 0)
                        break;
                }
              
                if (c == i)
                {
                    Console.WriteLine(i);
                    count++;
                }
                i++;
            }
            Console.ReadLine();
            }
        }
    }
