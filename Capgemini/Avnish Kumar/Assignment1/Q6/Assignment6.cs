//Program no.6 Find Overall Commission for the Quarter

using System;

namespace Capgemini
{
    internal class Program
    {

        public int commision(int a, int b)
        {
            int margin = 0;
            margin = (a * b) / 100;
            return margin;
        }

        public static void Main(string[] args)
        {
            Console.Write("Month-1 Sales in USD: ");
            int month1sales = Convert.ToInt32(Console.ReadLine());
           
            Console.Write("Month-2 Sales in USD: ");
            int month2sales = Convert.ToInt32(Console.ReadLine());
           
            Console.Write("Month-3 Sales in USD: ");
            int month3sales = Convert.ToInt32(Console.ReadLine());
           
            int totalsales = month3sales + month1sales + month2sales;
            Console.WriteLine("Total Sale for the Quarter: {0} USD", totalsales);

           
            
            int quarterlycommision = 0; 
            Program xyz = new Program();
            
            if (totalsales >= 20000)
            {
                quarterlycommision = xyz.commision(12, totalsales);
            }

           else if (totalsales>= 15000 && totalsales < 20000)
            {
                quarterlycommision = xyz.commision(10, totalsales);
            }
           else if (totalsales >= 10000 && totalsales<15000)
            {
                quarterlycommision = xyz.commision(5, totalsales);
            }
            else
            {
                quarterlycommision = 0 ;
            }


            int mincommision=0 ;
            mincommision= xyz.commision(3, totalsales);
            Console.WriteLine("Quarterly_Commission: {0} USD", quarterlycommision);
            Console.WriteLine("Monthly_Commission: {0} USD", mincommision);

            int totalcommision = 0 ;
            totalcommision = quarterlycommision + mincommision;
            Console.WriteLine("Overall Commission for the Quarter: {0} USD",totalcommision);



        }
    }

}
