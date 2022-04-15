using System;

namespace LibraryFunctions.Functions
{
    public sealed class Functions

    {
        // Assignment 1_Quetion 1
        // function sum_of_digit()     
        //calculating sum of digit
        public int sum_of_digit(string n)
        {
            int sum = 0;
            int n1 = Convert.ToInt32(n);
            while (n1 != 0)
            {
                sum = sum + n1 % 10;
                n1 = n1 / 10;
            }

            return sum;
        }



        //// Assignment 1_Quetion 2 
        ////function fact()           
        ////funtion fact will return an integer after calculating factorial of passed number(fact_n)
        //public int fact(int fact_n)
        //{
        //    if (fact_n == 1)
        //    return 1;
        //    else return fact_n * fact(fact_n - 1);
        //}



        ////  Assignment 1_Quetion 3 
        ////function printprimetill() & isPrime() 
        //// printing prime within the given range 
        //public void printprimetill(int range)
        //{
        //    for (int i = 1; i <= range; i++)
        //    {
        //        if (isprime(i))// return true or false
        //            Console.Write(i + ",");
        //    }

        //}
        //private bool isprime(int r)  // isprime() function will check the number is prime or not
        //{
        //    if (r == 1 || r == 0) return false;
        //    for (int i = 2; i < r; i++)
        //    // starts the loop from 2
        //    {
        //        if (r % i == 0) return false;
        //    }
        //    return true;
        //}




        ////  Assignment 1_Quetion 4 
        ////function  ispallidrome()
        ////checking pallidrome of string s
        //public bool IsPallidrome(string s)
        //{
        //    string rev = "";
        //    for (int i = s.Length - 1; i >= 0; i--)
        //    {
        //        rev += s[i].ToString();
        //    }
        //    if (rev == s) return true;
        //    else return false;
        //}




        ////  Assignment 1_Quetion 5 
        ////function  tabletill12()
        ////calculate table till multiple of 12
        //public void tabletill12(int number)
        //{
        //    int sum1 = 1;
        //    //store multiple in sum
        //    for (int i = 1; i < 13; i++)
        //    // loop starts from 1 to 12 
        //    {
        //        sum1 = number * i;
        //        Console.WriteLine("{0}*{1} = {2}", number, i, sum1);
        //        // print table in given problem format

        //    }
        //}
    }
}
