using System;

namespace palindrome
{
    internal class Program
    {
        /// <summary>
        /// method to check palindrome
        /// </summary>
        /// <param name="str"></param>
        static void isPalindrome(String str)
        {
            String s=str;
            String reverse = String.Empty;
            //for reverse of string
            for (int i = s.Length-1; i>=0;i--)
            {
                reverse += s[i].ToString();
            }
            //checking if reverse of string and string is equal or not
            if (reverse == s)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter the string");
            //calling palindrome method
            isPalindrome(Console.ReadLine());
        }
    }
}
