
//Program no.2   Find Factorial of a Number

 

using System;

namespace Capgemini
{
   internal class Program
   {
       public static void Main(string[] args)
       {
           Console.WriteLine("Enter the Number");
           int input = Convert.ToInt32(Console.ReadLine());
           int fact = 1;
           for (int i = 1; i <= input; i++)
           {
               fact = fact * i;
           }
           Console.WriteLine("Factorial of the number is : " + fact);
       }
   }

}
