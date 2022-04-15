using System;

namespace Question_2

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Input = 0;
            double fact=0;   /// data stored in fact can be high so we used double.
                            
                          
            string readInput;
            bool checking = true;
            //checking if the input is valid or not , if not valid the user is prompted again to enter input
            
            while (checking)
            {
                Console.WriteLine("Enter the number");
                readInput = Console.ReadLine();       //// this will take the input from the user.
                var isnumber=int.TryParse(readInput,out Input);
                if(isnumber)
                {
                    checking= false;
                    
                    if(Input<0)
                    {
                        checking=true;
                    }
                    if(Input>0)
                    {
                        fact = 1;
                    }
                }
            }
            
           
            
            while (Input>1)     //factorial not needed to be calculated if the number is 1.
            {
                fact=fact*(Input);
                Input = Input - 1;
            }
           

            Console.WriteLine("Factorial of given number is {0}",fact);  /// this will print the factorial as the output.
        }
    }
}
