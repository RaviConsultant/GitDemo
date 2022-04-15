using System;

namespace Commission
{
    internal class Program
    {
        // Function to calculate Quarterly Sales Commission
        // Calculated commission can be a float value even if sales are of uint datatype. So, the return type is taken as float 
        float Tsales(int m1, int m2, int m3)
        {
            float Tsales = m1 + m2 + m3;

            float Qcomm = 0;

            if (Tsales >= 20000)
            {
               Qcomm = Tsales * 12 / 100;
            }
            else if (Tsales >= 15000 && Tsales < 20000)
            {
                Qcomm = Tsales * 10 / 100;
            }
            else if (Tsales >= 10000 && Tsales < 15000)
            {
                Qcomm = Tsales * 5 / 100;
            }
            else
            {
                return Qcomm;
            }

            return Qcomm;
        }

        // Function to calculate Monthly Sales Commission
        // Calculated commission can be a float value even if sales are of uint datatype. So, the return type is taken as float
        float TotalMComm(int m1, int m2, int m3)
        {
            float Tsales = m1 + m2 + m3;

            float Mcomm = 0;

            if ((m1 >= 5000 &&m2 >= 5000) && m3 >= 5000)
            {
                float MComm = Tsales * 3 / 100;
            }

            return Mcomm;
        }
        static void Main(string[] args)
        {
        Again:
            //try catch block until provide suitable input
            try
            {

                // user input
                Console.Write("1st Month Sale in USD: ");
                int m1 = int.Parse(Console.ReadLine());
                Console.Write("2nd Month Sale in USD: ");
                int m2 = int.Parse(Console.ReadLine());
                Console.Write("3rd Month Sale in USD: ");
                int m3 = int.Parse(Console.ReadLine());

                Program p = new Program();

                // Output Statements
                int Tsales = m1 + m2 + m3;
                Console.WriteLine("Total Sale for the Quarter: " + Tsales + " USD");

                Console.WriteLine("Quarterly Commission: " + p.Tsales(m1, m2, m3) + " USD");

                Console.WriteLine("Minimum Commission: " + p.TotalMComm(m1, m2, m3) + " USD");

                float Overall_Commission = p.Tsales(m1, m2, m3) + p.TotalMComm(m1, m2, m3);
                Console.WriteLine("Overall Commission for the Quarter: " + Overall_Commission + " USD");

            }
            //catch block
            catch
            {
                goto Again;
            }
        }
    }
}
