namespace Capgemini
{
    internal class Problem3
    {
        /// <summary>
        /// Checking if no. is prime or not
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public bool isPrime(int a)
        {
            for (int i = 2; i < a; i++)
            {
                if (a % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Printing all the prime no. till given no.
        /// </summary>
        /// <param name="n"></param>
        public void prime(int n)
        {
            if (n == 1 || n == 0 )
            {
                Console.WriteLine("No prime numbers");
                return;
            }
            else
            {
                for (int i = 2; i <= n; i++)
                {
                    if (isPrime(i))
                    {
                        Console.WriteLine(i + " ");
                    }
                }
            }
        }


        static void Main(string[] args)
        {
            //Taking a natural no. as input to print all prime no. till it
            int num;
            try
            {
                Problem3 p = new Problem3();
                string input;
                do
                {
                    Console.WriteLine("Please enter a number (only a positive whole number):");
                    input = Console.ReadLine();

                } while (!(int.TryParse(input, out num)) || num < 0);

                Console.WriteLine("Prime numbers till " + num + " are:");
                p.prime(num);
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred: " + e.ToString());
            }
            
        }

    }
}
