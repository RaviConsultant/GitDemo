namespace Capgemini
{
    internal class Problem6
    {
        
        /// <summary>
        /// Calulates overall Quaterly Commission 
        /// </summary>
        /// <param name = "month1Sales" ></ param >
        /// < param name="month2Sales"></param>
        /// <param name = "month3Sales" ></ param >

        static public void overallQuatertlyCommission(int month1Sales, int month2Sales, int month3Sales)
        {
            int totalQuaterlySales = month1Sales + month2Sales + month3Sales;
            float quatertlyCommission = 0;
            float minCommission = 0;
            float totalQuatertlyCommission;

            if (totalQuaterlySales >= 20000)
            {
                quatertlyCommission = totalQuaterlySales * 12 / 100;
            }
            else if (totalQuaterlySales >= 15000 && totalQuaterlySales < 20000)
            {
                quatertlyCommission = totalQuaterlySales * 10 / 100;
            }
            else if (totalQuaterlySales >= 10000 && totalQuaterlySales < 15000)
            {
                quatertlyCommission = totalQuaterlySales * 5 / 100;
            }
            else
            {
                quatertlyCommission = 0;
            }

            if (month1Sales >= 5000 && month2Sales >= 5000 && month3Sales >= 5000)
            {
                minCommission = totalQuaterlySales * 3 / 100;
            }
            totalQuatertlyCommission = quatertlyCommission + minCommission;

            Console.WriteLine("Total Sale for the Quarter: " + totalQuaterlySales + " USD");
            Console.WriteLine("Quarterly_Commission: " + quatertlyCommission + " USD");
            Console.WriteLine("Minimum_Commission: " + minCommission + " USD");
            Console.WriteLine("Overall Commission for the Quarter: " + totalQuatertlyCommission + " USD");

        }


        static void Main(string[] args)
        {
            //Taking 3 month sales as input 
            int month1Sales, month2Sales, month3Sales;
            try
            {
                Console.WriteLine("Month-1 Sales in USD:");
                month1Sales = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Month-2 Sales in USD:");
                month2Sales = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Month-3 Sales in USD:");
                month3Sales = Convert.ToInt32(Console.ReadLine());
                overallQuatertlyCommission(month1Sales, month2Sales, month3Sales);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.ToString());
            }
            
        }

    }
}
