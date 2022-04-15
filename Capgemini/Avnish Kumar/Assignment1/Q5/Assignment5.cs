// Program no.5  Program to print mathematical table of given number till 12

using System;
namespace Capgemini
{
    internal class Program
    {


        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int input = Convert.ToInt32(Console.ReadLine());
            int table = 0;

            for (int i = 1; i <= 12; i++)
            {
                table = input * i;
                Console.Write("{0} * {1} = ", i, input);
                Console.WriteLine(table);

            }

        }
    }

}