using System;

namespace Assignment1_solution2
{
    internal class Program
    {
        //This is the solution of 2nd Question
        static void Main(string[] args)
        {
            uint x = 1;
            Console.Write("Type your number:- ");
            try
            {
                uint t = Convert.ToUInt32(Console.ReadLine());
                for (uint i = t; i > 0; i--)
                {
                    x = x * i;
                }
                Console.WriteLine("Factorial:- " + x);
            }
            catch (Exception ex)
            { Console.WriteLine(ex.ToString()); }

        }
    }
}
