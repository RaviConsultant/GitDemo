using System;

namespace factorial_of_no_given
{
    internal class Program
    {
        /// <summary>
        /// method to find a factorial
        /// </summary>
        /// <param name="no"></param>
        /// <returns></returns>
        static int factorial(int no)
        { 
            //checking if no is 0 or not
            if(no==0)
            {
                return 1;
            }
            else 
            {
                //calculating factorial
                return no * factorial(no - 1);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number you want to get factorial:");
            int num = Convert.ToInt32(Console.ReadLine()); //geeting input from user

            // to print the factorial of no
            Console.WriteLine(factorial(num));
        }
    }
}