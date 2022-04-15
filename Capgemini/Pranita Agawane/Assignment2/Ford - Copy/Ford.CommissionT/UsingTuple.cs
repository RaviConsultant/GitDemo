using System;

namespace Ford.CommissionT
{
    class UsingTuple
    {
        float Quarterly_Sales_Commission(Tuple<uint,uint,uint>Sales)
        {
            float Total_Quarterly_Sales = Sales.Item1 + Sales.Item2 + Sales.Item3;

            float q_commission = 0;

            if (Total_Quarterly_Sales >= 50000)
            {
                q_commission = Total_Quarterly_Sales * 5 / 100;
            }
            else if (Total_Quarterly_Sales >= 30000 && Total_Quarterly_Sales < 50000)
            {
                q_commission = Total_Quarterly_Sales * 45 / 1000;
            }
            else if (Total_Quarterly_Sales >= 20000 && Total_Quarterly_Sales < 30000)
            {
                q_commission = Total_Quarterly_Sales * 375 / 10000;
            }
            else if (Total_Quarterly_Sales >= 15000 && Total_Quarterly_Sales < 20000)
            {
                q_commission = Total_Quarterly_Sales * 25 / 1000;
            }
            else if (Total_Quarterly_Sales >= 10000 && Total_Quarterly_Sales < 15000)
            {
                q_commission = Total_Quarterly_Sales * 175 / 10000;
            }
            else
            {
                return q_commission;
            }

            return q_commission;
        }

        float Monthly_Sales_Commission(Tuple<uint, uint, uint> Sales)
        {
            float Total_Monthly_Sales = Sales.Item1 + Sales.Item2 + Sales.Item3;

            float m_commission = 0;

            if ((Sales.Item1 >= 12000 && Sales.Item2 >= 12000) && Sales.Item3 >= 12000)
            {
                m_commission = Total_Monthly_Sales * 245 / 10000;
                return m_commission;
            }

            else if ((Sales.Item1 >= 7500 && Sales.Item2 >= 7500) && Sales.Item3 >= 7500)
            {
                m_commission = Total_Monthly_Sales * 125 / 10000;
                return m_commission;
            }

            else
            {
                return m_commission;
            } 
        }

        static void Main(string[] args)
        {
            Console.Write("1st Month Sale in USD: ");
            uint sale_1 = uint.Parse(Console.ReadLine());
            Console.Write("2nd Month Sale in USD: ");
            uint sale_2 = uint.Parse(Console.ReadLine());
            Console.Write("3rd Month Sale in USD: ");
            uint sale_3 = uint.Parse(Console.ReadLine());

            var Sales = Tuple.Create(sale_1, sale_2, sale_3);

            UsingTuple ut = new UsingTuple();

            uint Total_Quarterly_Sales = Sales.Item1 + Sales.Item2 + Sales.Item3;
            Console.WriteLine("Total Sale for the Quarter: " + Total_Quarterly_Sales + " USD");

            Console.WriteLine("Quarterly Commission: " + ut.Quarterly_Sales_Commission(Sales) + " USD");

            Console.WriteLine("Minimum Commission: " + ut.Monthly_Sales_Commission(Sales) + " USD");

            float Overall_Commission = ut.Quarterly_Sales_Commission(Sales) + ut.Monthly_Sales_Commission(Sales);
            Console.WriteLine("Overall Commission for the Quarter: " + Overall_Commission + " USD");

        }
    }
}
