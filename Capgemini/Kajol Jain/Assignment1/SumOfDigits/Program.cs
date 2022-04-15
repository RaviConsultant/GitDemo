using System;

namespace SumOfDigits
{
    internal class Program
    {
        /// <summary>
        /// Method to calculate Sum of Digits
        /// </summary>
        /// <param name="number"></param>
        /// <returns>digitSum</returns>

          public int digitSum(int number)
        {
            int digitSum = 0, remainder;
            while (number > 0)
            {
                remainder = number % 10;
                digitSum += remainder;
                number = number / 10;
            }
            return digitSum;
        }
        static void Main(string[] args)
        {
            //declaring variable to takr users input
            int inputInteger;
            string input;

            //Creating Program class object to call method digitSum()
            Program objectProgram=new Program();

           Console.WriteLine("Please enter a number (only a positive whole number)");
            input =Console.ReadLine();
           
            

            //Validating User given input

            if(int.TryParse(input, out inputInteger) &&  inputInteger>0)
            {
                Console.WriteLine(objectProgram.digitSum(inputInteger));
            }

            while(!(int.TryParse(input, out inputInteger)) || inputInteger < 0)

            {
                Console.WriteLine("Please enter a number (only a positive whole number)");
                input = Console.ReadLine();

                if (int.TryParse(input, out inputInteger) && inputInteger > 0)
                {
                    
                    Console.WriteLine(objectProgram.digitSum(inputInteger));
                }


            }


             }
    }
}
