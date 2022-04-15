using System;

namespace FactorialOfNumber
{
    public class GetFactorial
    {
        public int FactorialOfNumber(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            else
                return (number * FactorialOfNumber(number - 1));
        }
    }
}
