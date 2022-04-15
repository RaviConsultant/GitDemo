using System;

namespace Exercise_6
{
    internal class Program
    {
        // Function to get sum of the input  
        void getTable(uint number)
        {
            int i;
 
            for (i = 1; i <= 12; i++)
            {
                Console.Write("{0} X {1} = {2} \n", number, i, number * i);

            }
        }

            static void Main(string[] args)
        {
        // In case, if user gives input other than 'uint', then this goto statement will reiterate the 
        // the Try - Catch Block untill suitable input is provided 
        Again:
            try
            {
                // user input
                Console.Write("Please enter a number(only a positive whole number): ");
                // value of 'uint' datatype is used because only positive whole number is the desired input 
                uint number = uint.Parse(Console.ReadLine());

                Program p = new Program();

                // output statement
                Console.WriteLine("This is the Multiplication: ");
                p.getTable(number);
            }

            catch
            {
                goto Again;
            }
        }
    }
}
