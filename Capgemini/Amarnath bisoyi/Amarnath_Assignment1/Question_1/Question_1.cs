using System;


/// In this program we are going to find the sum of the digits in the inout.
namespace Questiopn_1

{
    internal class Question_1
    {
        static void Main(string[] args)
        {

            int numberSum= 0;
            int input = 0;
            string read_console;
            bool validation = true;
            
            while (validation)
            {
                Console.WriteLine("Enter the digit whose sum of numkber you want to find ");
                read_console = Console.ReadLine();                             //taking the input from the user
                var isNumber = int.TryParse(read_console, out input);   
              
            }
            

             
            try
            {
                while (input > 0)
                {
                    numberSum = numberSum + (input % 10);                  // taking the lastnumber in the input number and adding it to the sum
                    input = input / 10;                                  // deleting the last number in the input number

                }
            }
            catch (Exception ex)
            { Console.WriteLine("error exists please contact Admin"); }    ///exception handling
            

            Console.WriteLine("The sum of digits in the given number is {0} .", numberSum);
        }

    }
}
