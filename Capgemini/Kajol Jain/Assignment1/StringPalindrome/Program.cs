using System;

namespace StringPalindrome
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            //Declaring string type variable
            string inputString;
            string reverseString="";

            //Declaring integer type variable to hold output of TryParse
            int output;
            
            Console.WriteLine("Enter String:");
            inputString = Console.ReadLine();


            //Checking if Input is of string type or not
            if (int.TryParse(inputString, out output))
            {
                Console.WriteLine("Enter only string value");
            }
            else 
            { 
            
             for (int i = inputString.Length-1; i>= 0; i--)
            {
                reverseString =  reverseString  +inputString[i].ToString();
            }

             //Checking if string is palindrome or not
            if(inputString==reverseString)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            }
           
        }
    }
}
