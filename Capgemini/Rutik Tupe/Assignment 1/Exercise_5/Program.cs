using System;

namespace Exercise_5
{
    internal class Program
    {
        // Function to calculate Quarterly Sales Commission
        // Calculated commission can be a float value even if sales are of uint datatype. So, the return type is taken as float 
        float Quarterly_Sales_Commission(uint sale_1, uint sale_2, uint sale_3)
        {
            float Total_Quarterly_Sales = sale_1 + sale_2 + sale_3;

            float q_commission = 0;

            if (Total_Quarterly_Sales >= 20000)
            {
                q_commission = Total_Quarterly_Sales * 12 / 100;
            }
            else if (Total_Quarterly_Sales >= 15000 && Total_Quarterly_Sales < 20000)
            {
                q_commission = Total_Quarterly_Sales * 10 / 100;
            }
            else if (Total_Quarterly_Sales >= 10000 && Total_Quarterly_Sales < 15000)
            {
                q_commission = Total_Quarterly_Sales * 5 / 100;
            }
            else 
            {
                return q_commission;
            }

            return q_commission;
        }

        // Function to calculate Monthly Sales Commission
        // Calculated commission can be a float value even if sales are of uint datatype. So, the return type is taken as float
        float Monthly_Sales_Commission(uint sale_1, uint sale_2, uint sale_3)
        {
            float Total_Monthly_Sales = sale_1 + sale_2 + sale_3;

            float m_commission = 0;

            if ((sale_1 >= 5000 && sale_2 >= 5000) && sale_3 >= 5000)
            {
                m_commission = Total_Monthly_Sales * 3 / 100;
            }

            return m_commission;
        }
        static void Main(string[] args)
        {
            // user input
            Console.Write("1st Month Sale in USD: ");
            uint sale_1 = uint.Parse(Console.ReadLine());
            Console.Write("2nd Month Sale in USD: ");
            uint sale_2 = uint.Parse(Console.ReadLine());
            Console.Write("3rd Month Sale in USD: ");
            uint sale_3 = uint.Parse(Console.ReadLine());

            Program p = new Program();

            // Output Statements
            uint Total_Quarterly_Sales = sale_1 + sale_2 + sale_3;
            Console.WriteLine("Total Sale for the Quarter: " + Total_Quarterly_Sales + " USD");

            Console.WriteLine("Quarterly Commission: " + p.Quarterly_Sales_Commission(sale_1, sale_2, sale_3) + " USD");

            Console.WriteLine("Minimum Commission: " + p.Monthly_Sales_Commission(sale_1, sale_2, sale_3) + " USD");

            float Overall_Commission = p.Quarterly_Sales_Commission(sale_1, sale_2, sale_3) + p.Monthly_Sales_Commission(sale_1, sale_2, sale_3);
            Console.WriteLine("Overall Commission for the Quarter: " + Overall_Commission + " USD");

        }
    }
}
