using System;

namespace Assign1_6
{
    class Solution
    {
        private double months1;
        private double months2;
        private double months3;

        Solution(double months1, double months2, double months3)
        {
            this.months1 = months1;
            this.months2 = months2;
            this.months3 = months3;
        }

        double totalSale()
        {
            return (months1 + months2 + months3);
        }

        double quarterlyCommission()
        {
            double total = totalSale();

            if (total >= 20000)
            {
                return total * 0.12;
            }
            else if (total >= 15000)
            {
                double res = 10 / 100;
                return total * 0.10;
            }
            else if (total >= 10000)
            {
                double res = 5 / 100;
                return total * 0.05;
            }
            else
                return 0;
        }

        double minimumCommission()
        {
            double total = totalSale();

            if (months1 >= 5000 && months2 >= 5000 && months3 >= 5000)
                return (total * 0.03);
            else
                return 0;
        }

        double overallCommission()
        {
            double total = quarterlyCommission() + minimumCommission();
            return total;
        }
    }

    public class Main
    {


        static void Main(string[] args)
        {
            try
            {
                Scanner sc = new Scanner(System.in);
                double months1 = sc.nextDouble();
                double months2 = sc.nextDouble();
                double months3 = sc.nextDouble();

                Solution s = new Solution(months1, months2, months3);
                DecimalFormat ft = new DecimalFormat("#.##");

                Console.WriteLine("Total Sale for the Quarter: " + ft.format(s.totalSale()) + " USD");
                Console.WriteLine("Quarterly_Commission: " + ft.format(s.quarterlyCommission()) + " USD");
                Console.WriteLine("Minimum_Commission: " + ft.format(s.minimumCommission()) + " USD");
                Console.WriteLine("Overall Commission for the Quarter: " + ft.format(s.overallCommission()) + " USD");

                sc.close();


            } catch (Exception e)
            {
                Console.ReadLine(e.getMessage());
            }

        }
    

