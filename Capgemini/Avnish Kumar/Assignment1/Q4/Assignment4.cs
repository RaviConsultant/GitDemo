
// Program no. 4 Check whether given string is Pailondrome or not


using System;

namespace Capgemini
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the String");
            string str = Console.ReadLine();
            string revstr = "";
            str = str.ToLower();  //Lower Casing the string 
            for (int i = str.Length - 1; i >= 0; i--)
            {
                revstr = revstr + str[i];
            }
            if (revstr == str)
            {
                Console.WriteLine("Yes");
            }
            else {
                Console.WriteLine("No");
                    }

        }

    }
}

