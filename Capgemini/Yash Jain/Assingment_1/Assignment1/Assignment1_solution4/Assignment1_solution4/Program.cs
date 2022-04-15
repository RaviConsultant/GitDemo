using System;

namespace Assignment1_solution4
{
    internal class Program
    {
        /// <summary>
        /// This method helps us to cheak our string is palindrome or not
        /// </summary>
        /// <param name="str"></param>
        public static void is_palindrome(String str)
        {
            int length = str.Length - 1;
            int p = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == str[length])
                {
                    length--;
                    continue;
                }
                else
                {
                    p++;
                    Console.WriteLine($"No {str} is not palindrome");
                    break;
                }
            }
            if (p == 0)
                Console.WriteLine($"Yes {str} is palindrome");
        }
        static void Main(string[] args)
        {
            Console.Write("Enter Your String:- ");
            String str = Console.ReadLine();
            is_palindrome(str);
        }
    }
}
