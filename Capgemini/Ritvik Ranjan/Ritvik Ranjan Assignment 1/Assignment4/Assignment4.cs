using System;
// program to check if given number is a palindroe or not
namespace Assignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fstr, sestr = string.Empty;
            Console.Write("Enter a string : ");
            fstr = Console.ReadLine();
            if (fstr != null)
            {
                for (int i = fstr.Length - 1; i >= 0; i--)
                {
                    sestr += fstr[i].ToString();
                }
                if (sestr == fstr)
                {
                    Console.WriteLine("String is a Palindrome ");
                }
                else
                {
                    Console.WriteLine("String is not a Palindrome  ");
                }
            }
            Console.ReadLine();


        }

    }
}
