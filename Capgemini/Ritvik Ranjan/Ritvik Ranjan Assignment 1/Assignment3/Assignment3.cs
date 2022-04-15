using System;
// Program to print prime numbers under the given numbers
namespace Assignment3
{
    internal class Assignment3
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

        }
    }
}
