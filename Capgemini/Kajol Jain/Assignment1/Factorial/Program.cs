using System;

using Utility;

namespace Factorial

{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declaring variable to take user input
            int number;
            string input;

            //declaring boolean variable to validate user input
            bool check = true;
            Console.WriteLine("Enter positive whole number");
            input = Console.ReadLine();


            //Creating Object of FactorialClass of Utility which contains factorial()
            FactorialClass objectFactorial = new FactorialClass();

            //validating user input
            while (check)
            {
                //if user given correct input then calling of factorial() and break the loop
                if (int.TryParse(input, out number) && number > 0)
                {
                   //Calling factorial() with the object of Class 

                    Console.WriteLine(objectFactorial.factorial(number));
                    check = false;
                }
                else if (!(int.TryParse(input, out number)) || number < 0)
                {
                    Console.WriteLine("Enter positive whole number");
                    input = Console.ReadLine();
                }
                else
                {

                    Console.WriteLine("Enter positive whole number");
                    input = Console.ReadLine();
                }
            }
          }
    }
}
