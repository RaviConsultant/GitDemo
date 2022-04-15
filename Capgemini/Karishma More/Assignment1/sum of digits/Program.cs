using System;

namespace sum_of_digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number(only a positive whole number): ");
            #region trycatch
            // if any exception occur
            try
            {
                #region Variable declration
                //getting input from user
                int num2 = Convert.ToInt32(Console.ReadLine());
                int remainder, sum = 0, number;
                number = num2;
                #endregion variable declration


                #region sum of digits
                while (num2 > 0)
                {
                    remainder = num2 % 10;
                    sum = sum + remainder;
                    num2 = num2 / 10;
                }
                #endregion sum of digits

                Console.WriteLine("The sum of digits of " + number + " is " + sum);
            }
            // if any error occur
            catch (Exception ex)
            {
               Console.WriteLine("Please enter a number(only a positive whole number): ");
                try
                {
                    int num1 = Convert.ToInt32(Console.ReadLine());
                }

                // if any error occur
                catch (Exception excep)
                {
                    Console.WriteLine("Please enter a number(only a positive whole number): ");
                }
                

            }
            #endregion trycatch
           
        }
    }
}
