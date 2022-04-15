using System;

namespace Commission
{
    internal class Program
    {
        /// <summary>
        /// method for calculating monthly comission
        /// </summary>
        /// <param name="sales"></param>

        public int monthly_salesCommission(int[] sales)
        {
            int commission = 0;
            int total_commission = 0;

            for (int i = 0; i < sales.Length; i++)
            {
                if (sales[i] >= 5000)
                {
                    //calculating commision monthly
                    commission = sales[i] * 3 / 100;
                }
                // adding 3 months commission 
                total_commission += commission;
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
            int commission = 0;
            if (sales >= 20000)
            {
                commission = sales * 10 / 100;
                return commission;
            }
            else if (sales >= 15000 || sales < 20000)
                {
                    commission = sales * 10 / 100;
                    return commission;
                }
                else if (sales >= 10000 || sales < 15000)
                    {
                        commission = sales * 5 / 100;
                        return commission;
                    }
                    else if (sales < 10000)
                        {
                            commission = sales * 0 / 100;
                            return commission;
                        }
                        else
                        {
                            return 0;
                        }

                    }
                
            /// <summary>
            /// method to calculate monthly minimum sales commission
            /// </summary>
            /// <param name="sales"></param>
            /// <returns></returns>

                int minimun_Commission(int[] sales)
                 {
            int min_commission = 0;
            int total_commission = 0;

            for(int i = 0; i < sales.Length; i++)
            {
                if(sales[i] > 5000)
                {
                    total_commission += sales[i];
                }
                min_commission = total_commission * 3 / 100; 

            }

            return min_commission;
        }


        static void Main(string[] args)
        {
            Program objectCommission=new Program(); 

            int[] sales = new int[3];

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Month - {0} Sales in USD:", i + 1);
                sales[i] = int.Parse(Console.ReadLine());
                 
            }

            // calling monthly commision method
            int month_commis = objectCommission.monthly_salesCommission(sales);

            // getting quarterly sales from monthly sales
            int quart_sales = 0;
            foreach (int sals in sales)
            {
                quart_sales += sals;
            }
            //printing quarterly sales
            Console.WriteLine("Total Sale for the Quarter: {0}",quart_sales+" USD");

            //calling quarterly commision method
            int quart_commis = objectCommission.Quarterly_Commission(quart_sales);
            Console.WriteLine("Quarterly Commission: {0}", quart_commis+" USD");

            //calculating overall commision
            int overall_commission = month_commis + quart_commis;

            Console.WriteLine("Minimum_Commission: {0}", objectCommission.minimun_Commission(sales)+" USD");

            //printing overall commission
            Console.WriteLine("Overall Commission for the Quarter: {0}" , overall_commission+" USD");
        }
    }
}
