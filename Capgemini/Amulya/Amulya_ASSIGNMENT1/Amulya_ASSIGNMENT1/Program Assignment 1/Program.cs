namespace Capgemini
{
    internal class Problem1
    {

        /// <summary>
        /// Calculating sum of digits
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        private int digitSum(int num)
        {
            int sumOfDigits = 0;
            for (; num != 0; num = num / 10)
            {
                sumOfDigits = sumOfDigits + num % 10;
            }
            return sumOfDigits;
        }


        static void Main(string[] args)
        {
            //Taking a no. as input to find sum of the digits of the given no.
            int number;
            try
            {
                Problem1 p = new Problem1();
                string input;
                do
                {
                    Console.WriteLine("Please enter a number (only a positive whole number):");
                    input = Console.ReadLine();

                }
                while (!(int.TryParse(input, out number)) || number < 0);
                Console.WriteLine("The sum of digits of " + input + " is " + p.digitSum(number));
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: "+ex.ToString());
            }
        }

    }
}





