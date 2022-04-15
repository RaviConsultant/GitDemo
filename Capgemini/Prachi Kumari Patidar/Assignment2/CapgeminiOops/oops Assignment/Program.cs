using System;
using Ford.assignmentLib;
namespace CommissionT
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int[] monthA = new int[3];// reading values from commind line
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Month - {0} Sales in USD:", i + 1);
                monthA[i] = Convert.ToInt32(Console.ReadLine());

            }
            var monthT = Tuple.Create(monthA[0], monthA[1], monthA[2]);// creating tuple as per problem reference
            int sum = monthT.Item1 + monthT.Item2 + monthT.Item3;

            int[] month = new int[] { monthT.Item1, monthT.Item2, monthT.Item3 };//storing values in array
            Commission c = new Commission();// creating instance of library class to implement library functions

            Console.WriteLine("Total Sale for the Quarter: {0} USD", sum);
            Console.WriteLine("Quarterly_Commission: {0} USD", c.Quaterly_Commission(sum));
            Console.WriteLine("Minimum_Commission: {0} USD", c.Monthly_Commission(month, sum));
            Console.WriteLine("Overall Commission for the Quarter: {0} USD", c.Monthly_Commission(month, sum) + c.Quaterly_Commission(sum));
        }
    }
}
