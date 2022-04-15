using System;
// to check whether the given input is palindrome or not. 


namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Input;
            int stringLength;

            Console.WriteLine("Enter your string to check wether its palindrome or not ");    // taking th einput
            Input = Console.ReadLine();                                                      // reading input string
            stringLength=Input.Length;                                                      //taking the length

            int counter = 0;                                                              // Initializing  with value 0 
            for(int i=1;i<=stringLength/2;i++)
            {

                if(Input[i-1]!=Input[stringLength-i])                                ///logic of palindrome

                {
                    Console.WriteLine("{0} it is not a palindrome",Input);
                    counter=1;
                    break;
                }

            }
            if(counter==0)                                ///if the value of counter becomes zero that means its a palindrome.
            {
                Console.WriteLine("{0} give strin is a palindrome", Input);
            }

        }

    }
}
