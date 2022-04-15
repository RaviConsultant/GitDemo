using System;

namespace CommissionOfcompany
{
    internal class Program
    {
        public static void overallcomission(int _1MonthSale, int _2MonthSale, int _3MonthSale)
        {
            int totalSale = _1MonthSale + _2MonthSale + _3MonthSale;
            float quaterlySaleCommission = 0, quaterlySaleMinCommission = 0, totalQuaterlyCommission = 0;
            if (totalSale >= 20000)
            {
                quaterlySaleCommission = totalSale * 12 / 100;
            }
            else if (totalSale >= 15000 && totalSale < 20000)
            {
                quaterlySaleCommission = totalSale * 10 / 100;
            }
            else if (totalSale >= 10000 && totalSale < 15000)
            {
                quaterlySaleCommission = totalSale * 5 / 100;
            }
            else
            {
                quaterlySaleCommission = 0;
            }

            if (_1MonthSale >= 5000 && _2MonthSale >= 5000 && _3MonthSale >= 5000)
            {
                quaterlySaleMinCommission = totalSale * 3 / 100;
            }
            totalQuaterlyCommission = quaterlySaleCommission + quaterlySaleMinCommission;

            Console.WriteLine("Total Sale for the Quarter: " + totalSale + " USD");
            Console.WriteLine("Quarterly_Commission: " + quaterlySaleCommission + " USD");
            Console.WriteLine("Minimum_Commission: " + quaterlySaleMinCommission + " USD");
            Console.WriteLine("Overall Commission for the Quarter: " + totalQuaterlyCommission + " USD");
        }
        public static void Main()
        {
            try
            {
                int _1MonthSale, _2MonthSale, _3MonthSale;
                Console.WriteLine("Enter 1st Month sale");
                _1MonthSale = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter 2nd Month sale");
                _2MonthSale = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter 3rd Month sale");
                _3MonthSale = int.Parse(Console.ReadLine());
                overallcomission(_1MonthSale, _2MonthSale, _3MonthSale);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "Enter Valid details");
                int _1MonthSale, _2MonthSale, _3MonthSale;
                Console.WriteLine("Enter 1st Month sale");
                _1MonthSale = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter 2nd Month sale");
                _2MonthSale = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter 3rd Month sale");
                _3MonthSale = int.Parse(Console.ReadLine());
                overallcomission(_1MonthSale, _2MonthSale, _3MonthSale);
            }
        }
    }
}
