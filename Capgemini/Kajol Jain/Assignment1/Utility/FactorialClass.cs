using System;

namespace Utility
{
    public class FactorialClass
    {
        /// <summary>
        /// Method to find factorial of given numbers
        /// </summary>
        /// <param name="number"></param>
        /// <returns>factorial</returns>
        public int factorial(int number)
        {
            int i, factorial = 1;

            for (i = 1; i <= number; i++)
            {
                factorial = factorial * i;
            }
            return factorial;

        }
    }
}
