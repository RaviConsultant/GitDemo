using System;

namespace Factorial
{
    internal class Program
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
                    Console.ReadLine();
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
