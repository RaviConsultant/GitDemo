using System;

namespace Assignment_1
{
    internal class SumofDigit
    {
        int getSum(int n)
        {
            //declare variable sum for calculating sum
            int sum;

            /* Single line that calculates sum */
            for (sum = 0; n > 0; sum += n % 10, n /= 10)
                ;

            return sum;
        }

        // Entry Point
        public static void Main()
        {
            //try catch block until suitable input is provided
            Again:
            try
            {

                Console.Write("Input  a number(integer): ");
                int n = Convert.ToInt32(Console.ReadLine());
                SumofDigit sumdigit = new SumofDigit();
                //Suitable output
                Console.Write(sumdigit.getSum(n));
            }
            catch
            {
                goto Again;
            }
        }
    }
}