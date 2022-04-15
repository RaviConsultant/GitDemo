using System;

namespace Assignment1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("Please enter a number:");   //taking input from user 
                int input = Convert.ToInt32(Console.ReadLine()); //accepting input from user
                int sum = 0;
                while (input != 0)
                {
                    sum += input % 10;  //applying formula   
                    input /= 10;
                }
                Console.WriteLine("The sum of digits of given number is:" + sum); //displaying final output
            }
            catch (Exception ex) //handling exception
            {
                Console.WriteLine("error: " + ex.ToString());


            }
        }
    }
}
