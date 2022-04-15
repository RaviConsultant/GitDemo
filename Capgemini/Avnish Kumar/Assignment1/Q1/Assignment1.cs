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
            try
            {
                int sumOfNumbers = 0;
                int intigerInput = 0;
                string read_from_console;
                bool validation = true;
                #region Validation
                while (validation)
                {
                    Console.WriteLine("Enter a Number to find the sum of its numbers");
                    read_from_console = Console.ReadLine();                             //Reading input from the user for the number and validating it is a number is done below
                    var isNumber = int.TryParse(read_from_console, out intigerInput);   //tryparse returns true if the read_from_console is strictly a whole positive number
                    if (isNumber)                                                       // isNumber is alloted a boolean value in the above satment
                    {
                        validation = false;                                             // validation is changed to falsu because it is a number
                        if (intigerInput < 0)
                            validation = true;                                          // validation is true because it is a negative number and can't be accepted
                    }
                }
                #endregion

                #region Sum
                try
                {
                    while (intigerInput > 0)
                    {
                        sumOfNumbers = sumOfNumbers + (intigerInput % 10);                  // taking the lastnumber in the input number and adding it to the sum
                        intigerInput = intigerInput / 10;                                  // deleting the last number in the input number

                    }
                }
                catch (Exception ex)
                { Console.WriteLine("An error occured please contact Admin"); }
                #endregion

                Console.WriteLine("The sum of inegers in the given number is {0} .", sumOfNumbers);

            }
            catch(Exception ex)
            {
                Console.WriteLine("An unexpected error occured please contact the admin");
            }
        }

    }
}
