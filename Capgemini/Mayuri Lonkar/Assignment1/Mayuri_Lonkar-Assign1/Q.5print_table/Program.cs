using System;

namespace print_table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = 7;

            int range = 18;

            // looping from 1 to range to print the
            // multiplication table of the number.
            int i = 1;

            // using while loop
            while (i <= range)
            {

                // printing the N*i,ie ith multiple of N.
                Console.Write(N + " * " + i + " = "
                                   + N * i);
                i++;
            }
          
        }
    }
 }

