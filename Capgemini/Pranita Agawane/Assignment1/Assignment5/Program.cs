using System;

namespace Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            Console.Write("Input the number  : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
            for (i = 1; i <= 12; i++)
            {
                Console.Write("{1} X {0} = {2} \n", n, i, n * i);
            }
        }
    }
}
