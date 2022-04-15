using System;

namespace Exercise_3
{
    internal class Program
    {

        //Function to display list of Prime numbers betwwen 0 and the input number 
        void Prime(uint number)
        {
            int i, j, flag;
            // flag variable to tell if i is prime or not

            for (i = 2; i <= number; i++)
            {
                flag = 1; 

                for (j = 2; j <= i / 2; ++j)
                {
                    if (i % j == 0)
                    {
                        flag = 0;
                        break;
                    }
                }

                if (flag == 1)
                    Console.WriteLine(i);

                // flag = 1 means i is prime
                // and flag = 0 means i is not prime
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
                Console.WriteLine("Prime numbers between 0 and " + number + " are: ");
                p.Prime(number);
            }

            catch
            {
                goto Again;
            }
        }
    }
}
