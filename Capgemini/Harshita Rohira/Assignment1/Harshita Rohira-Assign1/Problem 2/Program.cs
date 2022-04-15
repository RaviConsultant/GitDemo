namespace Capgemini
{
    internal class Problem2
    {
        /// <summary>
        /// Calculating factorial of given no.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        private double factorial(int n)
        {
            double fact = 1;
            if (n == 0 || n == 1)
            {
                return 1;
            }
            for (int i = 2; i <= n; i++)
            {
                fact = i * fact;
            }
            return fact;
        }


        static void Main(string[] args)
        {
 
            // Taking a natural no. as input to find out its factorial
            int num;
            try
            {
                Problem2 p = new Problem2();
                string input;
                do
                {
                    Console.WriteLine("Please enter a number(only a positive whole number):");
                    input = Console.ReadLine();
                } while (!(int.TryParse(input, out num)) || num < 0);
                Console.WriteLine("The factorial of " + num + " is " + p.factorial(num));
            }
            catch (Exception ex)
            { 
                Console.WriteLine("An error occurred: " + ex.ToString()); 
            }

        }

    }
}