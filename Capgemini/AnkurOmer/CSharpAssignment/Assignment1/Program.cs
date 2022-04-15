using System;
using SumOfDigits;
using NumberIsPalindrome;
using NumberIsPrime;
using FactorialOfNumber;
using MathsTable;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;
            Console.WriteLine("Type of operation you like to perform:");
            Console.WriteLine("1 for Sum of Digits, 2 for factorial number, 3 to print prime number, 4 to check palindrome ,5 to get maths table:");
            int x = Convert.ToInt32(Console.ReadLine());

            #region Sum of Digits
            SOD d = new SOD();
            if (x == 1)
            {
                int digits;
                Console.WriteLine("Please enter a number (only a positive whole number):");
                string digitsText = Console.ReadLine();
                while (repeat)
                    try
                    {
                        digits = Int32.Parse(digitsText);
                        Console.WriteLine(d.SumOfDigits(digits));
                        repeat = false;
                    }
                    catch (System.FormatException)
                    {
                        //Console.WriteLine("Invalid Input. \nMessage {0}", exFE);
                        Console.WriteLine("Please enter a number (only a positive whole number):");
                        digitsText = Console.ReadLine();
                        repeat = true;
                    }
            }
            #endregion Sum of Digits

            #region Factorial of number
            else if (x == 2)
            {
                int num;
                GetFactorial F = new GetFactorial();    
                Console.WriteLine("Please enter a number (only a positive whole number):");
                string facText = Console.ReadLine();
                while (repeat)
                    try
                    {
                        num = Int32.Parse(facText);
                        Console.WriteLine(F.FactorialOfNumber(num));
                        repeat = false;
                    }
                    catch (System.FormatException)
                    {
                        //Console.WriteLine("Invalid Input. \nMessage {0}", exFE);
                        Console.WriteLine("Please enter a number (only a positive whole number):");
                        facText = Console.ReadLine();
                        repeat = true;
                    }
            }
            #endregion Factorial of number

            #region Checking prime number

            else if (x == 3)
            {
                int primeNum;
                CheckPrime P = new CheckPrime();
                Console.WriteLine("Please enter a number (only a positive whole number):");
                string primeText = Console.ReadLine();

                while (repeat)
                    try
                    {
                        primeNum = Int32.Parse(primeText);
                        for (int i = 2; i < primeNum; i++)
                            P.isPrime(i);
                        repeat = false;
                    }
                    catch (System.FormatException)
                    {
                        //Console.WriteLine("Invalid Input. \nMessage {0}", exFE);
                        Console.WriteLine("Please enter a number (only a positive whole number):");
                        primeText = Console.ReadLine();
                        repeat = true;
                    }
            }

            #endregion Checking prime number

            #region Checking palindrome number

            else if (x == 4)
            {
                string palindromeString = null;
                CheckPalindrome p = new CheckPalindrome();
                Console.WriteLine("Please enter a valid string:");
                palindromeString = Console.ReadLine();

                while (repeat)
                    try
                    {
                        Console.WriteLine(p.isPalindrome(palindromeString));
                        repeat = false;
                    }
                    catch (System.FormatException)
                    {
                        //Console.WriteLine("Invalid Input. \nMessage {0}", exFE);
                        Console.WriteLine("Please enter a valid string:");
                        palindromeString = Console.ReadLine();
                        repeat = true;
                    }
            }

            #endregion Checking palindrome number

            #region getting maths table number

            else if (x == 5)
            {
                int num;
                Table T = new Table();
                Console.WriteLine("Please enter a positive number:");
                string numText = Console.ReadLine();

                while (repeat)
                    try
                    {
                        num = Int32.Parse(numText);
                        T.TableOfNumber(num);
                        repeat = false;
                    }
                    catch (System.FormatException)
                    {
                        //Console.WriteLine("Invalid Input. \nMessage {0}", exFE);
                        Console.WriteLine("Please enter a valid string:");
                        numText = Console.ReadLine();
                        repeat = true;
                    }
            }

            #endregion getting maths table number

        }
    }
}

