namespace Capgemini
{
    internal class Problem4
    {
        /// <summary>
        /// To Check if given string is palindrome or not
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public string palindrome(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            string s1 = new string(arr);
            bool p = s.Equals(s1);
            if (p == true)
            {
                return "Yes";
            }
            else
            {
                return "No";
            }
        }


        static void Main(string[] args)
        {
            try
            {
                Problem4 p = new Problem4();
                //Taking a string as input to check if string is palindrome or not
                
                string s;
                do
                {
                    Console.WriteLine("Enter a string:");
                    s = Console.ReadLine();
                }
                while (string.IsNullOrEmpty(s));
                Console.WriteLine(p.palindrome(s));
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.ToString());
            }
            
}

    }
}
