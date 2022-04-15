using System;

namespace MultiplicationTable
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
                Console.ReadLine();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex + "Enter valid Number");
                Console.WriteLine("Enter a Number");
                num = int.Parse(Console.ReadLine());
                Console.WriteLine("------------------------");

                p.PrintTable(num); 
                Console.ReadLine();

            }

        }
    }
}
