using System;

namespace Sourabh_Jain_Assign1
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
