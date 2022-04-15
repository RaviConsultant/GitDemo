namespace Capgemini
{
    internal class Problem5
    {
        /// <summary>
        /// Print table of given no. till 12 
        /// </summary>
        /// <param name="n"></param>
        private void printTable(int n)
        {
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine(i + " * " + n + " = " + n * i);
            }
        }

        static void Main(string[] args)
        {
          
            // Taking a natural no. as input to print its table
            int num;
            try
            {
                Problem5 p = new Problem5();
                string input;
                do
                {
                    Console.WriteLine("Please enter a number (only a positive whole number):");
                    input = Console.ReadLine();
                }
                while (!(int.TryParse(input, out num)) || num < 0);
                p.printTable(num);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.ToString());
            }

        }

    }
}
