using System;

namespace commission
{
    internal class Program
    {
        /// <summary>
       /// method for calculating monthly comission
       /// </summary>
      /// <param name="sales"></param>
         int Month_Commission(int[] sales)
         {
            //declaring variable for commision calculation
            int comm = 0;
            int total_commission = 0;
            for (int i = 0; i < sales.Length; i++)
            {
                if (sales[i] >= 5000)
                {
                    //calculating commision monthly
                    comm = sales[i] * 3 / 100;
                }
                // adding 3 months commission 
                total_commission += comm;
            }
            //returning total commision of 3 mnoths
            return total_commission;
         }




        /// <summary>
        /// method for calculating quarterly commision
        /// </summary>
        /// <param name="sales"></param>
        int Quarterly_Commission(int sales)
        {
            int comm = 0;
            //checking sales
            if (sales >= 20000)
            {
                comm = sales * 10 / 100;
                return comm;
            }
            else
            {
                //checking sales 
                if (sales >= 15000 || sales < 20000)
                {
                    comm = sales * 10 / 100;
                    return comm; 
                }
                else
                {
                    //checking sales
                    if (sales >= 10000 || sales < 15000)
                    {
                        comm = sales * 5 / 100;
                        return comm;
                    }
                    else
                    {
                        //checking sales
                        if (sales < 10000)
                        {
                            comm = sales * 0 / 100;
                            return comm;
                        }
                        else 
                        {
                            return 0;
                        }
                        
                    }
                }
            }

        }
        static void Main(string[] args)
        {
            Program prg = new Program();
            //geeting sales in usd
            int[] sales = new int[3];
            for (int i = 0; i< sales.Length; i++)
            {
                Console.WriteLine("enter the "+(i+1)+" month sale ");
                //getting sales from user
                sales[i] = int.Parse(Console.ReadLine());
            }
            // calling monthly commision method
            int month_commis=prg.Month_Commission(sales);

            // getting quarterly sales from monthly sales
            int quart_sales=0;
            foreach (int sals in sales) 
            {
                quart_sales += sals;
            }
            //printing quarterly sales
            //Console.WriteLine(quart_sales);

            //calling quarterly commision method
            int quart_commis=prg.Quarterly_Commission(quart_sales);

           //calculating overall commision
           int overall_commission = month_commis + quart_commis;

            //printing overall commission
            Console.WriteLine("overall commision = " + overall_commission);
        }
    }
}
