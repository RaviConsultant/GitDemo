using System;

namespace PremKumarAss1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Writeline("start");
        }
    }
}

//Problem statemnt-1 :- program to compute sum of digits in number.
using System;

namespace PremKumarAss1
{
    public class Program
    {
        private int Sumofdigit(int num)
        {

            if (num == 0)
            {
                return 0;
            }
            return (num % 10 + Sumofdigit(num / 10));
        }
        static void Main(string[] args)
        {
            int num;
            Program p = new Program();
            try
            {
                Console.WriteLine("Enter a number:");
                num = int.Parse(Console.ReadLine());
                Console.WriteLine("sum = " + p.Sumofdigit(num));
            }
            catch (Exception ex)
            {
                Console.WriteLine(" Enter a number!" + ex.Message);
                Console.WriteLine("Enter a Number");
                num = int.Parse(Console.ReadLine());
                p.Sumofdigit(num);
            }


        }
    }
}

//Problem statemnt-2 :- program to find factorial of given number
using System;

namespace PremKumarAss1
{
    public class Program
    {
        public int Factorial(int num)
        {
            int fact = 1;
            if (num == 0 || num == 1)
            {
                return 1;
            }
            for (int i = 1; i <= num; i++)
            {
                fact = fact * i;
            }
            return fact;
        }
        public static void Main(String[] args)
        {

            Program p = new Program();
            try
            {
                Console.WriteLine("Please Enter a Number");
                int num;
                num = int.Parse(Console.ReadLine());
                if (num > 0)
                {
                    Console.WriteLine("Factorial of " + num + "is: " + p.Factorial(num));
                }
                while (num <= 0)
                {
                    Console.WriteLine("Enter a valid Number");
                    num = int.Parse(Console.ReadLine());
                    Console.WriteLine("Factorial of " + num + "is: " + p.Factorial(num));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex + "Enter a Number");
                Console.WriteLine("Please Enter a Number");
                int num = int.Parse(Console.ReadLine());
                p.Factorial(num);

            }

        }

    }
}



//Problem statemnt-3 :-program to print first n prime numbers
 
using System;

namespace PremKumarAss1
{
    internal class Program
    {
        public bool IsPrime(int j)
        {
            //int i = 2;
            for (int i = 2; i < j; i++)
            {
                if (j % i == 0)
                {
                    return false;
                }
                //return true;
            }
            return true;
        }
        public void Prime(int n)
        {
            if (n == 0)
            {
                return;
            }
            else
            {
                for (int i = 2; i <= n; i++)
                {
                    if (IsPrime(i))
                    {
                        Console.WriteLine(i + " ");

                    }
                }

            }
        }
        public static void Main()
        {
            int num;
            Console.WriteLine("Enter a Number");
            num = int.Parse(Console.ReadLine());
            Program p = new Program();
            if (num > 0)
            {
                Console.WriteLine("prime numbers till " + num + " are: " + "\n---------------");
                p.Prime(num);
            }
            while (num <= 0)
            {
                Console.WriteLine("Enter valid number");
                num = int.Parse(Console.ReadLine());
                Console.WriteLine("prime numbers till" + num + " are: " + "\n---------------");
                p.Prime(num);
            }
        }
    }
}


//Problem statemnt-4 :- Program to verify whether string is palindrome or not 
using System;

namespace PremKumarAss1
{
    internal class Program
    {
        public string Palindrome(string inputstr)
        {
            string reversestr = string.Empty;
            for (int i = inputstr.Length - 1; i >= 0; i--)
            {
                reversestr += inputstr[i].ToString();
            }
            if (reversestr == inputstr)
            {
                return ("YES");
            }
            else
            {
                return ("NO");
            }
        }
        public static void Main()
        {
            Console.WriteLine("Enter a string");
            string inputstr;
            inputstr = Console.ReadLine();
            Program p = new Program();
            if (inputstr != " ")
            {
                Console.WriteLine(p.Palindrome(inputstr));
            }
            while (inputstr == "")
            {
                Console.WriteLine("invalid string");
                //Console.WriteLine("Enter a string");
                inputstr = Console.ReadLine();
                Console.WriteLine(p.Palindrome(inputstr));
            }
        }
    }
}

 //Problem statemnt-5 :-Program for the mathematical table

using System;

namespace PremKumarAss1
{
    internal class Program
    {
        public void PrintTable(int num)
        {
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine(i + " X " + num + " = " + num * i);
            }
        }
        public static void Main()
        {
            int num;
            Program p = new Program();
            try
            {
                Console.WriteLine("Enter a Number");
                num = int.Parse(Console.ReadLine());
                Console.WriteLine("------------------------");

                p.PrintTable(num);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex + "Enter valid Number");
                Console.WriteLine("Enter a Number");
                num = int.Parse(Console.ReadLine());
                Console.WriteLine("------------------------");

                p.PrintTable(num);
            }

        }
    }
}


 //Problem statemnt-6 :- Program For Salescommision

using System;
namespace PremKumarAss1
{
    internal class Program
    {
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
            Console.Write("1st Month Sale in USD: ");
            uint sale_1 = uint.Parse(Console.ReadLine());
            Console.Write("2nd Month Sale in USD: ");
            uint sale_2 = uint.Parse(Console.ReadLine());
            Console.Write("3rd Month Sale in USD: ");
            uint sale_3 = uint.Parse(Console.ReadLine());

            Program p = new Program();

            uint Total_Quarterly_Sales = sale_1 + sale_2 + sale_3;
            Console.WriteLine("Total Sale for the Quarter: " + Total_Quarterly_Sales + " USD");
            Console.WriteLine("Quarterly Commission: " + p.Quarterly_Sales_Commission(sale_1, sale_2, sale_3) + " USD");
            Console.WriteLine("Minimum Commission: " + p.Monthly_Sales_Commission(sale_1, sale_2, sale_3) + " USD");
            float Overall_Commission = p.Quarterly_Sales_Commission(sale_1, sale_2, sale_3) + p.Monthly_Sales_Commission(sale_1, sale_2, sale_3);
            Console.WriteLine("Overall Commission for the Quarter: " + Overall_Commission + " USD");

        }
    }
}
