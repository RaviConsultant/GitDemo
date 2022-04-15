using System;

namespace Program
{
    internal class Program
    {
        public static int Factorial(int num)
        {
            if (num == 1)
            {
                return 1;
            }
            else
            {
                return num * Factorial(num - 1);
            }
        }
        static void Main(string[] args)
        {

            /*
             using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1st Program
            //do
            //{
            //    int sum=0;
            //    // message shown on screen
            //    Console.WriteLine("Please enter a number (only a positive whole number): ");
            //    string input = (Console.ReadLine());
            //    int number;
            //    // convert string into integer
            //    if (int.TryParse(input, out number))
            //    {
            //        //Console.WriteLine((number));
            //        //while loop for sumof digits of the number
            //        while (number > 0)
            //        {
            //            int m = number%10;
            //             sum = sum + m;
            //            number=number/10;
            //        }
            //        Console.WriteLine("Sum is= " + sum);

            //        break;
            //    }
            //    else continue;

            //}while (true);



            //// 2nd program
            //do
            //{
            //   Console.WriteLine("enter value to find factorial :");
            //    string input = (Console.ReadLine());
            //   int number;
            //    if (int.TryParse(input, out number))
            //    {
            //        Console.WriteLine(fact(number));
            //        Console.ReadLine();
            //        break;
            //    }
            //    else Console.WriteLine("wrong input");

            //        continue;
            //}while (true);


            // //3rd program

            // int a=1, i, j, count;

            //Console.WriteLine("enter your value :");
            //string range1 =(Console.ReadLine());
            //int.TryParse(range1, out var b);

            // for ( i = a; i <= b; i++)
            // {
            //     if (i == 1 || i == 0)
            //         continue;
            //     count = 1;
            //     for ( j = 2; j <= i/2; j++)
            //     {
            //         //   for (int j = 2; j <= range; j++)
            //         // {
            //         if (i % j == 0)
            //         {
            //             count = 0;
            //             break;
            //         }
            //     }
            //     if (count == 1)
            //         Console.WriteLine(i);
            // }


            ////4th
            //Console.WriteLine(ispal("NAMAN"));



            //// 5th Program 
            //table_till_12(7);


            //// 6th Program
            //int[] month = new int[3];
            //int sum = 0;
            //for(int i = 0; i < month.Length; i++)
            //{
            //    Console.WriteLine("Total sale for the Quarter: {0}", i+1);
            //    month[i] = Convert.ToInt32(Console.ReadLine());
            //    sum+=month[i];
            //}
            //Console.WriteLine("Total Sale for the Quarter : {0}", sum);
            //Console.WriteLine("quarterly_Commission: {0}",Quaterly_Com( sum));
            //Console.WriteLine("Minimum_Commission: {0}", Monthly_Com(month));
            //Console.WriteLine("Overall Commission for the Quarter: {0}", Monthly_Com(month) + Quaterly_Com(sum));

        }


        ////2nd
        //public static int fact(int number)
        //{
        //    if(number==1)return 1;
        //    else return number *fact(number-1);
        //}


        ////4th
        //public static bool ispal(string s)
        //{
        //    string rev = "";
        //    for(int i = s.Length-1;i>=0; i--)
        //    {
        //        rev=rev+s[i].ToString();
        //    }
        //    if(rev==s)
        //        return true;
        //    else return false;
        //}



        ////5TH
        //public static void table_till_12(int r)
        //{
        //    int sum ;
        //    for (int i = 1; i <= 12; i++)
        //    {
        //        sum = r * i;
        //        Console.WriteLine("{0}*{1}={2}" ,r,i,sum);
        //        sum = 1;
        //    }
        //}


        ////6th
        //public static int Monthly_Com(int[] m)
        //{
        //    int sum = 0;
        //    for (int i = 0; i < m.Length; i++)
        //    {
        //        if (m[i] >= 5000) sum += (m[i] / 100) * 3;
        //        else sum += 0;
        //    }
        //    return sum;

        //}

        //public static int Quaterly_Com(int s)
        //{
        //    int r = s / 100;
        //    if (s >= 20000) return r * 12;
        //    else if (s >= 15000 && s < 20000) return r * 10;
        //    else if (s >= 10000 && s < 15000) return r * 5;
        //    else return 0;
        //}
    }
}
             */

        }
    }
}
