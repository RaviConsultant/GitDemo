using System;

/* Program to take an intiger as an input and print the sum of the number in the intiger as output
The logic being used here is that we read a number from the user and start taking the last number from 
the input number and adding it to sum after the number is added into sum this is deleted from the number
*/
namespace Assignment1
{
    internal class Assignment1
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" Enter any number:");   //taking input from user 
            int input = Convert.ToInt32(Console.ReadLine()); //accepting input from user
            int sum = 0;
            while (input != 0)
            {
                sum += input % 10;  //applying formula   
                input /= 10;
            }
            Console.WriteLine("The sum of digits of given number is:" + sum); //displaying final output
            
        }

    }
}
