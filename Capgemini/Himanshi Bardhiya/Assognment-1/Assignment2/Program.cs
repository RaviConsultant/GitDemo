using System;

namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, fact = 1, number;  //initializing 
            Console.Write("Enter any Number: ");   //taking input from user 
            number = int.Parse(Console.ReadLine());  //accepting input from user
            for (i = 1; i <= number; i++)    
            {
                fact = fact * i; //formula for the factorial of numbers
            }
            Console.Write("Factorial of " + number + " is: " + fact); //displaying final output
        }
    }
}