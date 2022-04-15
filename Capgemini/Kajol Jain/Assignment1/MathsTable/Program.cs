using System;

using System;

using Utility;

namespace MathsTable

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


            //Creating Object of MathsTableClass of Utility which contains table()
            MathsTableClass objectMathsTableClass = new MathsTableClass();

            //validating user input
            while (check)
            {
                //if user given correct input then calling of table() and break the loop
                if (int.TryParse(input, out number) && number > 0)
                {
                    //Calling table() with the object of MathsTableClass 

                    objectMathsTableClass.table(number);
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
