using System;

namespace Ford.CommissionS
{

    public struct Sales
    {
        public uint Sales_1, Sales_2, Sales_3;
    }

    class UsingStruct
    {

        float Quarterly_Sales_Commission(Sales S)
        {
            // Sales S2;

            float Total_Quarterly_Sales = S.Sales_1 + S.Sales_2 + S.Sales_3;

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

        float Monthly_Sales_Commission(Sales S)
        {
            float Total_Monthly_Sales = S.Sales_1 + S.Sales_2 + S.Sales_3;

            float m_commission = 0;

            if ((S.Sales_1 >= 12000 && S.Sales_2 >= 12000) && S.Sales_3 >= 12000)
            {
                m_commission = Total_Monthly_Sales * 245 / 10000;
                return m_commission;
            }

            else if ((S.Sales_1 >= 7500 && S.Sales_2 >= 7500) && S.Sales_3 >= 7500)
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
            Sales S;

            Console.Write("1st Month Sale in USD: ");
            S.Sales_1 = uint.Parse(Console.ReadLine());
            Console.Write("2nd Month Sale in USD: ");
            S.Sales_2 = uint.Parse(Console.ReadLine());
            Console.Write("3rd Month Sale in USD: ");
            S.Sales_3 = uint.Parse(Console.ReadLine());

            UsingStruct st = new UsingStruct();

            uint Total_Quarterly_Sales = S.Sales_1 + S.Sales_2 + S.Sales_3;
            Console.WriteLine("Total Sale for the Quarter: " + Total_Quarterly_Sales + " USD");

            Console.WriteLine("Quarterly Commission: " + st.Quarterly_Sales_Commission(S) + " USD");

            Console.WriteLine("Minimum Commission: " + st.Monthly_Sales_Commission(S) + " USD");

            float Overall_Commission = st.Quarterly_Sales_Commission(S) + st.Monthly_Sales_Commission(S);
            Console.WriteLine("Overall Commission for the Quarter: " + Overall_Commission + " USD");
        }
    }
}
