using System;

namespace Solution1
{
    //Monthly Sales Commission Using Tuple:-
    internal class Program
    {
        static double MonthlySalesComission(int month)
        {
            if (month >= 7500)
            {
                return (month * 1.25) / 100;
            }
            //else if (month >= 12000)
            //{
            //    return (month * 2.45) / 100;
            //}

            else
            {
                return month;
            }


        }
        static double QuaterlySalesComission(double sales)
        {
            if (sales >= 50000)
            {
                return (sales * 5) / 100;
            }
            else if (sales >= 30000)
            {
                return (sales * 4.5) / 100;
            }
            else if (sales >= 20000)
            {
                return (sales * 3.75) / 100;
            }
            else if (sales >= 15000)
            {
                return (sales * 2.5) / 100;
            }
            else if (sales >= 10000)
            {
                return (sales * 1.75) / 100;
            }
            else
            {
                return sales;
            }
        }
        static int TotalSale(int first, int second, int third)
        {
            return first + second + third;
        }
        static void Main(string[] args)
        {
            Console.Write("Month-1 Sales in USD:");
            int firstmonth = Convert.ToInt32(Console.ReadLine());
            Console.Write("Month-2 Sales in USD:");
            int secondmonth = Convert.ToInt32(Console.ReadLine());
            Console.Write("Month-3 Sales in USD:");
            int thirdmonth = Convert.ToInt32(Console.ReadLine());
            var tup = Tuple.Create(firstmonth, secondmonth, thirdmonth);
            int totalsale = TotalSale(tup.Item1, tup.Item2, tup.Item3);
            double quaterlycomission = QuaterlySalesComission(totalsale);
            double month1_com = MonthlySalesComission(tup.Item1);
            double month2_com = MonthlySalesComission(tup.Item2);
            double month3_com = MonthlySalesComission(tup.Item3);
            double monthlycomission = month1_com + month2_com + month3_com;
            double totalsalescomission = monthlycomission + quaterlycomission;
            Console.WriteLine($"Total Sale for the Quarter: {totalsale} USD");
            Console.WriteLine($"Quarterly overall Sales Commission: {quaterlycomission} USD");
            Console.WriteLine($"Monthly Minimum Commission: {monthlycomission} USD");
            Console.WriteLine($"Total Commission for the Quarter: {totalsalescomission} USD");
        }
    }
}




    //2nd way of solving this question
    //    struct MonthlySalesComission{
    //        public double MonthlyComission(int month)
    //        {
    //            if (month >= 7500)
    //            {
    //                return (month * 1.25) / 100;
    //            }
    //            //else if (month >= 12000)
    //            //{
    //            //    return (month * 2.45) / 100;
    //            //}

//            else
//            {
//                return month;
//            }


//        }
//    }

//    struct QuaterlySalesComission
//    {
//        public double QuaterlyComission(double sales)
//        {
//            if (sales >= 50000)
//            {
//                return (sales * 5) / 100;
//            }
//            else if (sales >= 30000)
//            {
//                return (sales * 4.5) / 100;
//            }
//            else if (sales >= 20000)
//            {
//                return (sales * 3.75) / 100;
//            }
//            else if (sales >= 15000)
//            {
//                return (sales * 2.5) / 100;
//            }
//            else if (sales >= 10000)
//            {
//                return (sales * 1.75) / 100;
//            }
//            else
//            {
//                return sales;
//            }
//        }
//    }
//        internal class Program
//    {
//        static int TotalSale(int first, int second, int third)
//        {
//            return first + second + third;
//        }
//        static void Main(string[] args)
//        {
//            Console.Write("Month-1 Sales in USD:");
//            int firstmonth = Convert.ToInt32(Console.ReadLine());
//            Console.Write("Month-2 Sales in USD:");
//            int secondmonth = Convert.ToInt32(Console.ReadLine());
//            Console.Write("Month-3 Sales in USD:");
//            int thirdmonth = Convert.ToInt32(Console.ReadLine());
//            int totalsale = TotalSale(firstmonth, secondmonth, thirdmonth);
//            MonthlySalesComission msc = new MonthlySalesComission();
//            QuaterlySalesComission qsc = new QuaterlySalesComission();

//            double quaterlycomission = qsc.QuaterlyComission(totalsale);
//            double month1_com = msc.MonthlyComission(firstmonth);
//            double month2_com = msc.MonthlyComission(secondmonth);
//            double month3_com = msc.MonthlyComission(thirdmonth);
//            double monthlycomission = month1_com + month2_com + month3_com;
//            double totalsalescomission = monthlycomission + quaterlycomission;
//            Console.WriteLine($"Total Sale for the Quarter: {totalsale} USD");
//            Console.WriteLine($"Quarterly overall Sales Commission: {quaterlycomission} USD");
//            Console.WriteLine($"Monthly Minimum Commission: {monthlycomission} USD");
//            Console.WriteLine($"Total Commission for the Quarter: {totalsalescomission} USD");

//        }
//    }
//}
