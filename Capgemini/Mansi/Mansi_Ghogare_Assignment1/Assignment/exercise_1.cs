using System;

namespace Exercise_1
{
    internal class Program
    {
        // Function to get sum of the input 
        // Sum of digits of a uint number will also be a uint. So, return type is uint 
        uint getSum(uint number)
        {
            // Variable sum initiated to carry sum of digits after each iteration
            uint sum = 0;

            while (number != 0)
            {
                sum = sum + number % 10;
                number = number / 10;
            }

            return sum;
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
                Console.WriteLine("The sum of digits of  " + number + " is " + p.getSum(number));
            }

            catch
            {
                goto Again;
            }

        }
    }
}