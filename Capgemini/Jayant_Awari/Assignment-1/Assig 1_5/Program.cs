using System;

namespace Assig_1_5
{
    internal class Program
    {
        static void Main(string[] args)
        { 
        
           int n =int.Parse(Console.ReadLine());

            for (int i = 1; i <= 12; ++i)
            {
                Console.Write(n + " * " + i +
                                  " = " + n *
                                   i + "\n");
            }
            
        }
    }
}
