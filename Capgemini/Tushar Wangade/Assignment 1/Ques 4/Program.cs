using System;

namespace Assignment_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Again:
            //try catch block until suitable input is provided
            try
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
            catch
            { 
                goto Again;
            }

        }
    }
}
