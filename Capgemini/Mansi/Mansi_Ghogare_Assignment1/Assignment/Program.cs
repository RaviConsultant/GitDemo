using System;

namespace Assignment
{
    //class SumofDigits
    //{
    //    static void Main(string[] args);

    //Console.WriteLine("Hello World!");

    //public static void Main(string[] args)
    //9999 = 9 + 9 + 9 + 9 = 36,< -o / p....

    //int n, sum = 0, m;

    //try 


    //{
    //    Console.Write(" Please enter a number(only positive number): ");
    //   n = int.Parse(Console.ReadLine());

    //    while (n > 0)
    //    {
    //        m = n % 10;
    //        sum = sum + m;
    //        n = n / 10;
    //    }
    //    Console.Write("Sum is= " + sum);
    //}
    //catch(FormatException)
    //{
    //    Console.Write("The entered number is not valid ,enter a positive number: ");

    //}
    //finally
    //{
    //    n = int.Parse(Console.ReadLine());
    //    while (n > 0)
    //    {
    //        m = n % 10;
    //        sum = sum + m;
    //        n = n / 10;
    //    }
    //    Console.Write("Sum is= " + sum);
    //    //Console.WriteLine("Please enter a number(only positive number : ");

    //}

    //{
    //    Console.WriteLine("Please enter a number(only positive number): ");
    //    n = int.Parse(Console.ReadLine());
    //}




    //prime numbers...

    class Prime_Number
    {
        public static void Main()
        {
            int ct = 0, n = 0, i = 1, j = 1;
            while (n < 10)
            {
                j = 1;
                ct = 0;
                while (j <= i)
                {
                    if (i % j == 0)
                    ct++;
                    j++;
                }
                    if (ct == 2)
                    {
                       Console.Write(i);
                       Console.Write(" ");
                       n++;
                    }
                    i++;
                }
            }
        }
    }

    












