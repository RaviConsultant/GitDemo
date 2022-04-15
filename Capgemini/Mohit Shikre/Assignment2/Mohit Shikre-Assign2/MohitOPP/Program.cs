using System;
using IBank.Utility1;

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
        public void OpenAccount() { Console.WriteLine("Opening an account"); }
        public void Deposit() { Console.WriteLine("Deposit money in account"); }
        public void Close_Account() { Console.WriteLine("Closing an account"); }
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
        {// example of impementing of type saving account
            SB_Account sbaccount = new SB_Account();
            sbaccount.OpenAccount();
            sbaccount.Deposit();
            sbaccount.Withdraw();
            sbaccount.Close_Account();

            // // example of impementing of type Current account
            Current_Account cuaccount = new Current_Account();
            cuaccount.OpenAccount();
            cuaccount.Deposit();
            cuaccount.Withdraw();
            cuaccount.Close_Account();

            // example of impementing of type FD account
            FD_Account fdaccount = new FD_Account();
            fdaccount.OpenAccount();
            fdaccount.Deposit();
            fdaccount.Close_Account();

            //// example of impementing of type RD account
            RD_Account rdaccount = new RD_Account();
            rdaccount.OpenAccount();
            rdaccount.Deposit();
            
            rdaccount.Close_Account();
        }
    }
}
