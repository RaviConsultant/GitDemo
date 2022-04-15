using System;
using IBank.Utility;

namespace IBank.Design1
{

    /// <summary>
    /// Creating Account class's data members and methods as per problemdesign statement
    /// </summary>
    public class Account
    {
        public Account() { }
        public int AccNo;
        Customer Cust;
        Branch Branch;
        int CurrentBalance;
        public void OpenAccount()
        {
            Console.WriteLine("Opening an account");
        }
        public void Deposit()
        {
            Console.WriteLine("Deposit money in account");
        }
        public void Close_Account()
        {
            Console.WriteLine("Closing an account");
        }
    }
    public class SB_Account : Account
    {
        public void Withdraw()
        {
            Console.WriteLine("Withdraw money from account");
        }
    }
    public class Current_Account : Account
    {
        public void Withdraw()
        {
            Console.WriteLine("Withdraw money from account");
        }
    }
    public class FD_Account : Account { }
    public class RD_Account : Account { }
    internal class Program
    {
        static void Main(string[] args)
        {// example code
            SB_Account sbaccount = new SB_Account();
            sbaccount.OpenAccount();
            sbaccount.Deposit();
            sbaccount.Withdraw();
            sbaccount.Close_Account();
        }
    }
}