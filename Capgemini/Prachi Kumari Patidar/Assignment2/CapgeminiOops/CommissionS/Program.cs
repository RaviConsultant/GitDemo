using System;
using Ford.assignmentLib;
namespace CommissionS
{
    internal class Program
    {
        // Calculate  Commission using Structure
        public struct Month
        {
            public int[] mon;

        };
        static void Main(string[] args)
        {

            Month month = new Month();
            month.mon = new int[3];

            int sum = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Month - {0} Sales in USD:", i+1);
                month.mon[i] = Convert.ToInt32(Console.ReadLine());
                sum += month.mon[i];
            }
            Commission c = new Commission();

            Console.WriteLine("Total Sale for the Quarter: {0} USD", sum);
            Console.WriteLine("Quarterly_Commission: {0} USD", c.Quaterly_Commission(sum));
            Console.WriteLine("Minimum_Commission: {0} USD", c.Monthly_Commission(month.mon, sum));
            Console.WriteLine("Overall Commission for the Quarter: {0} USD", c.Monthly_Commission(month.mon, sum) + c.Quaterly_Commission(sum));
        }
    }
}
