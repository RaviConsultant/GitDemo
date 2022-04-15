using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Que_5_Print_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, num;

            //Reading number
            Console.WriteLine("Enter number to print table: ");
            num = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= 10; i++)
            {
                //Printing table of number entered by user            
                Console.Write("{0} X {1} = {2} \n", num, i, num * i);
            }
            Console.ReadLine();
        }
    }
}
