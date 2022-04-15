using System;

namespace Assignment1_solution5
{
    internal class Program
    {
        //This is the solution question 5
        static void Main(string[] args)
        {
            int t = 0;
            while (t == 0)
            {
                try
                {
                    Console.Write("Enter your number:- ");
                    int x = Convert.ToInt32(Console.ReadLine());
                    for (int i = 1; i <= 12; i++)
                    {
                        int table = x * i;
                        Console.WriteLine($"{x} * {i} = {table}");
                    }
                    t++;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Invalid Input");
                    Console.WriteLine("Program will execute until you give valid input");
                }
            }
        }
    }
}
