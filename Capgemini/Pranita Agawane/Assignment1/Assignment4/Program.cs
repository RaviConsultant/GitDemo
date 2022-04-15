using System;

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
                    Console.WriteLine("String is Palindrome ");
                }
                else
                {
                    Console.WriteLine("String is not Palindrome  ");
                }
            }
            Console.ReadLine();
        }
    }
}
