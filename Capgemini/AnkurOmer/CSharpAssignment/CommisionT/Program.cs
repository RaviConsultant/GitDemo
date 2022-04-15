using System;

namespace CommisionS
{
    internal class Program6
    {
        struct SalesInMonth
        {
            public int Month1;
            public int Month2;
            public int Month3;

            public void getSalesInMonth(int M1,int M2,int M3)
            {
                this.Month1 = M1;
                this.Month2 = M2;
                this.Month3 = M3;
            }
        }

        static int CalcTotalSales(SalesInMonth Sm)
        {
            return Sm.Month1 + Sm.Month2 + Sm.Month3;
        }

        static double CalcQuadSalesCommission(int TS)
        {

            if (TS < 10000)
                return TS * 0.0;
            else if (TS > 10000 && TS < 15000)
                return TS * 1.75/100;
            else if (TS > 15000 && TS < 20000)
                return TS * 2.5 / 100;
            else if (TS > 20000 && TS < 30000)
                return TS * 3.25 / 100;
            else if (TS > 30000 && TS < 50000)
                return TS * 4.5 / 100;
            else 
                return TS * 5.0 / 100;

        }

        static double CalcMonSalesCommission(SalesInMonth S, int T)
        {
            if (S.Month1 >= 7500 && S.Month2 >= 7500 && S.Month3 >= 7500)
                return T * 1.25 / 100;
            else if (S.Month1 >= 12000 && S.Month2 >= 12000 && S.Month3 >= 12000)
                return T * 2.45 / 100;
            else
                return 0.0;
        }


        static void Main(string[] args)
        {
            SalesInMonth Sales = new SalesInMonth();
            int m1 = Convert.ToInt32(Console.ReadLine());
            int m2 = Convert.ToInt32(Console.ReadLine());
            int m3 = Convert.ToInt32(Console.ReadLine());

            int TotalSales;
            Sales.getSalesInMonth(m1, m2, m3);
            TotalSales = CalcTotalSales(Sales);
            Console.WriteLine(TotalSales);
            Console.WriteLine(CalcQuadSalesCommission(TotalSales));
            Console.WriteLine(CalcMonSalesCommission(Sales, TotalSales));


        }
    }
}
