using System;

namespace question_4
{
    internal class Program{
        // Function to Reverse a String
        string ReverseString(string in_string){
            string rev_in_string = "";

            for(int i = in_string.Length - 1; i >= 0; i--){
                rev_in_string = rev_in_string + in_string[i].ToString();
            }
            return rev_in_string;
        }
        static void Main(string[] args){
            //input
            Console.Write("Enter a String: ");
            string in_string = Console.ReadLine();

            Program p = new Program();
            
            // If the reverse string matches the original string then it is a pallindrome else not
            if (in_string == p.ReverseString(in_string)){
                Console.WriteLine("YES, " + in_string + " is a Palindrome !!");
            }
            else{
                Console.WriteLine("NO, " + in_string + " is not a Palindrome.");
            }
        }
    }
}