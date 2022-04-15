using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_no_1_Sum_of_digit
{
    internal class Program
    {
        static void Main(string[] args)
        { //Question no- 1
            Console.WriteLine(" Enter any number:");   //Taking input from user 
            int input = Convert.ToInt32(Console.ReadLine()); //Accepting input from user
            int sum = 0;
            while (input != 0)
            {
                sum += input % 10;  //Formula apply  

                input /= 10;
            }
            Console.WriteLine("The sum of digits of given number is:" + sum);


            Console.ReadLine();

        }
    }
}
