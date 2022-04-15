using System;

namespace NumberIsPalindrome
{
    public class CheckPalindrome
    {
        public string isPalindrome(string str)
        {
            string yes = "Yes", no = "No";

            string reverse = String.Empty;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                reverse += str[i].ToString();
            }
            if (reverse == str)
            {
                return yes;
            }
            else { return no; }
        }
    }
}
