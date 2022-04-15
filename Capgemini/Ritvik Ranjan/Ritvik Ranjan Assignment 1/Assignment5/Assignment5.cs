using System;
// Multiplication table upto 12
namespace Assignment5
{
    internal class Assignment5
    {
        static void Main(string[] args)
        {
            int i, n;
                    Console.Write("Enter any number  : ");
                    n = Convert.ToInt32(Console.ReadLine());
                    Console.Write("\n");
                    for (i = 1; i <= 12; i++)
                    {
                        Console.Write("{1} X {0} = {2} \n", n, i, n * i);
                    }
        }
    }
}
