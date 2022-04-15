using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
    public class MathsTableClass
    {

        /// <summary>
        /// method to print table of given number 
        /// </summary>
        /// <param name="number"></param>
        public  void table(int number)
        {
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine("{0} *{1}  = {2}", number, i, (number * i));
            }
        }
    }
}
