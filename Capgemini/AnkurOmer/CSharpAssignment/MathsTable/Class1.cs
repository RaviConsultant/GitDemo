using System;

namespace MathsTable
{
    public class Table
    {
        public void TableOfNumber(int num)
        {
            for (int i = 1; i <= 10; i++)
            {
                //Printing table of number entered by user            
                Console.Write("{0} X {1} = {2} \n", num, i, num * i);
            }
        }
    }
}
