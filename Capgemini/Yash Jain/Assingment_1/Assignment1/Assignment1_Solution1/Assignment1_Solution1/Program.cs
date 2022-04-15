using System;

namespace Assignment1_Solution1
{
    internal class Program
    {
        //This is the solution of our first problem
        /// <summary>
        /// This method helps us to sum all the numbers given as an input
        /// </summary>
        static void Main(string[] args)
        {
            int p = 0;
            while (p == 0)
            {
                Console.Write("Please enter a number (only a positive whole number):");
                String input = Console.ReadLine();
                uint l;
                if (UInt32.TryParse(input, out l))
                {
                    uint num = Convert.ToUInt32(input);
                    uint sum = 0;
                    uint m;
                    while (num > 0)
                    {
                        m = num % 10;
                        sum = sum + m;
                        num = num / 10;
                    }
                    Console.WriteLine($"The sum of digits of {input} is {sum}");
                    break;
                }
                else
                {
                    continue;
                }
            }

        }

    }
}
