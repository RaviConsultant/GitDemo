using System;

namespace Assignment1_solution6
{
    internal class Program
    {
        //This is the solution for question 6:-
        /// <summary>
        /// This method return us total sales
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static int totalsale(int a, int b, int c)
        {
            return a + b + c;
        }



        /// <summary>
        /// This method returns quaterly comission
        /// </summary>
        /// <param name="quaterly"></param>
        /// <returns></returns>
        public static int quaterly_commission(int quaterly)
        {
            if (quaterly >= 20000)
                return (quaterly * 12) / 100;
            else if (quaterly >= 15000 && quaterly < 20000)
                return (quaterly * 10) / 100;
            else if (quaterly >= 10000 && quaterly < 15000)
                return (quaterly * 5) / 100;
            else return quaterly;
        }


        /// <summary>
        /// This method returns monthly commission
        /// </summary>
        /// <param name="monthly"></param>
        public static int monthly_commission(int monthly)
        {
            if (monthly >= 5000)
                return (monthly * 3) / 100;
            else
                return 0;
        }

        static void Main(string[] args)
        {
            int t = 0;
            while (t == 0)
            {
                try
                {
                    Console.Write("Month 1 sales in USD:");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Month 2 sales in USD:");
                    int b = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Month 3 sales in USD:");
                    int c = Convert.ToInt32(Console.ReadLine());
                    int total_sale = totalsale(a, b, c);
                    int total_quaterly = quaterly_commission(total_sale);
                    int month1 = monthly_commission(a);
                    int month2 = monthly_commission(b);
                    int month3 = monthly_commission(c);
                    int total_monthly = month1 + month2 + month3;
                    int over_all = total_monthly + total_quaterly;
                    Console.WriteLine("Total Sale for the Quarter:" + total_quaterly);
                    Console.WriteLine("Quarterly_Commission:" + total_quaterly);
                    Console.WriteLine("Minimum_Commission:" + total_monthly);
                    Console.WriteLine("Overall Commission for the Quarter:" + over_all);
                    t++;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Invalid Input, Please try again");
                }
            }
        }
    }
}
