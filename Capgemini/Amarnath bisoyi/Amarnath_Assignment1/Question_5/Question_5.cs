using System;
// program to print the table of given number till its 12th multiple.
namespace Assignment5
{
    internal class Question_5
    {
        static void Main(string[] args)
        {
            int Input=0;

            bool validation = true;
            int i;
            while (validation)
            {
                string readInput;
                Console.WriteLine("Enter the number whose table you want");   /// it will take the input 
                readInput = Console.ReadLine();                              /// it will take the input
                var isvalid = int.TryParse(readInput, out Input);
                if (isvalid)
                {
                    validation = false;
                    if (Input < 0)
                    {
                        validation = true;
                    }
                }

            }
            Console.Clear();               //Clearing the console
            for(i=1;i<=12;i++)
            {
                Console.WriteLine("{0}\t*\t{1}\t=\t{2}", i, Input, i*Input);      //i*intigerInput gives product
            }
        }
    }
}
