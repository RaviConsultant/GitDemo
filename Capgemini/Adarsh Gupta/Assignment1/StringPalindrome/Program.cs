using System;

namespace StringPalindrome
{
    internal class Program
    {
        public string Palindrome(string inputstr)
        {
            string reversestr = string.Empty;
            for (int i = inputstr.Length - 1; i >= 0; i--)
            {
                reversestr += inputstr[i].ToString();
            }
            if (reversestr == inputstr)
            {
                return ("YES");
            }
            else
            {
                return ("NO");
            }
        }
        public static void Main()
        {
            Console.WriteLine("Enter a string");
            string inputstr;
            inputstr = Console.ReadLine();
            Program p = new Program();
            if (inputstr != " ")
            {
                Console.WriteLine(p.Palindrome(inputstr));
                Console.ReadLine();
            }
            while (inputstr == "")
            {
                Console.WriteLine("invalid string");
                //Console.WriteLine("Enter a string");
                inputstr = Console.ReadLine();
                Console.WriteLine(p.Palindrome(inputstr));
                Console.ReadLine();
            }
        }
    }
}
