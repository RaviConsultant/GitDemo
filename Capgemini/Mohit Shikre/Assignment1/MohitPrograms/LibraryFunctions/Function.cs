using System;

namespace LibraryFunctions.Functions
{
    public sealed class Functions

    {
                                                            // Problem 1 :function sumofdigit() declaration & definition    
        /// <summary>
     /// calculating sum of digit
     /// </summary>
     /// <param name="n"></param>
     /// <returns></returns>
        public int sumofdigit(string n)
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
                                                        // Problem 2 :function fact() declaration & definition             
        /// <summary>
        ///funtion fact will return an integer after calculating factorial of passed number(fact_n)
        /// </summary>
        /// <param name="f"></param>
        /// <returns></returns>
        public int fact(int fact_n)
        {
            if (fact_n == 1) return 1;// this statement return 1 when fact_n=1 its the breaking point of reccursion
            else return fact_n * fact(fact_n - 1);// ussing reccursion concept to calculate factorial
        }
                                               
                                                      // Problem 3 :function printprimetill()& isPrime() declaration & definition
        /// <summary>
        /// fuction will print prime within given range 
        /// </summary>
        /// <param name="range"></param>
        public void printprimetill(int range)
        {
            for (int i = 1; i <= range; i++)
            {
                if (isprime(i))// return true or false
                    Console.Write(i + ",");
            }

        }
        /// <summary>
        /// isprime() function will check the number is prime or not & 
        /// </summary>
        /// <param name="r"></param>
        /// <returns> return bool type </returns>
        private bool isprime(int r)
        {
            if (r == 1 || r == 0) return false;// return false for 1 & 0
            for (int i = 2; i < r; i++)// starts the loop from 2
            {
                if (r % i == 0) return false;
            }
            return true;
        }

                                                            // Problem 4 :function  ispallidrome() declaration & definition
        /// <summary>
        /// ispal function is for checking pallidrome of string s return true or false
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool IsPallidrome(string s)
        {
            string rev = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                rev += s[i].ToString();
            }
            if (rev == s) return true;
            else return false;
        }
                                                       // Problem 5 :function  tabletill12() declaration & definition
        /// <summary>
        /// tabletill12 will calculate table till multiple of 12 for given number
        /// </summary>
        /// <param name="r"></param>
        public void tabletill12(int number)
        {
            int sum1 = 1;//store multiple in sum
            for (int i = 1; i < 13; i++)// loop starts from 1 to 12 
            {
                sum1 = number * i;
                Console.WriteLine("{0}*{1} = {2}", number, i, sum1);// print table in given problem format

            }
        }
    }
}
