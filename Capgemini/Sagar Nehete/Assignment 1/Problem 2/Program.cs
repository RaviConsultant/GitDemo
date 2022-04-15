using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oue_no_2.Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y = 1, num;
            Console.Write("enter the number : ");
            num = Convert.ToInt32(Console.ReadLine());
            for (x = 1; x <= num; x++)
                y = y * x;
            Console.WriteLine(y);
            Console.ReadLine();

        }
    }
}
