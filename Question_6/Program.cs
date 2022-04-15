using System;

namespace question_6
{
    internal class Program{
        // Function to calculate Quarterly Sales Commission
        // Calculated commission can be a float value even if sales are of uint datatype. So, the return type is taken as float 
        float QuarterlySalesCommission(uint sale_1, uint sale_2, uint sale_3){
            float CumulativeQuarterlySales = sale_1 + sale_2 + sale_3;
            float q_commission = 0;

            if (CumulativeQuarterlySales >= 20000){
                q_commission = CumulativeQuarterlySales * 12 / 100;
            }
            else if (CumulativeQuarterlySales >= 15000 && CumulativeQuarterlySales < 20000){
                q_commission = CumulativeQuarterlySales * 10 / 100;
            }
            else if (CumulativeQuarterlySales >= 10000 && CumulativeQuarterlySales < 15000){
                q_commission = CumulativeQuarterlySales * 5 / 100;
            }
            else{
                return q_commission;
            }
            return q_commission;
        }

        // Function to calculate Monthly Sales Commission
        // Calculated commission can be a float value even if sales are of uint datatype. So, the return type is taken as float
        float MonthlySalesCommission(uint sale_1, uint sale_2, uint sale_3){
            float TotalMonthlySales = sale_1 + sale_2 + sale_3;

            float m_commission = 0;

            if ((sale_1 >= 5000 && sale_2 >= 5000) && sale_3 >= 5000){
                m_commission = TotalMonthlySales * 3 / 100;
            }

            return m_commission;
        }
        static void Main(string[] args){
            // user input
            Console.Write("Month 1 Sale in USD: ");
            uint sale_1 = uint.Parse(Console.ReadLine());
            Console.Write("Month 2 Sale in USD: ");
            uint sale_2 = uint.Parse(Console.ReadLine());
            Console.Write("Month 3 Sale in USD: ");
            uint sale_3 = uint.Parse(Console.ReadLine());

            Program p = new Program();

            // Output Statements
            uint TotalQuarterlySales = sale_1 + sale_2 + sale_3;
            Console.WriteLine("Total Sale for the Quarter: " + TotalQuarterlySales + " USD");
            Console.WriteLine("Quarterly Commission: " + p.QuarterlySalesCommission(sale_1, sale_2, sale_3) + " USD");
            Console.WriteLine("Minimum Commission: " + p.MonthlySalesCommission(sale_1, sale_2, sale_3) + " USD");
            float Overall_Commission = p.QuarterlySalesCommission(sale_1, sale_2, sale_3) + p.MonthlySalesCommission(sale_1, sale_2, sale_3);
            Console.WriteLine("Overall Commission for the Quarter: " + Overall_Commission + " USD");
        }
    }
}
