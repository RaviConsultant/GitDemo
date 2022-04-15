using System;

namespace Assignment
{
    class sum_of_digits
    {
        static int getSum(int n)
        {
            int sum = 0;
            int rem;
            while (n != 0)
            {
                rem = n % 10;
                sum = (sum + rem);
                n = n / 10;
            }
            return sum;
        }

        public static void Main(string[] args)
        {
            Console.Write("Please enter a number (only a positive whole number): ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The sum of digits of " + n + " is " + getSum(n));
        }

    }
}
