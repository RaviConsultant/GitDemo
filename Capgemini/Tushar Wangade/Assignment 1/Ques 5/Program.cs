﻿using System;

namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Again:
            //try catch block until provide suitable input
            try
            {

                string inpstr, revstr = string.Empty;
                Console.Write("Enter a string : ");
                inpstr = Console.ReadLine();
                if (inpstr != null)
                {
                    for (int i = inpstr.Length - 1; i >= 0; i--)
                    {
                        revstr += inpstr[i].ToString();
                    }
                    if (revstr == inpstr)
                    {
                        Console.WriteLine("String is Palindrome Input = {0} and Output= {1}", inpstr, revstr);
                    }
                    else
                    {
                        Console.WriteLine("String is not Palindrome Input = {0} and Output= {1}", inpstr, revstr);
                    }
                }
                Console.ReadLine();
            }
            catch
            {
                goto Again;
            }
        }
    }
}
