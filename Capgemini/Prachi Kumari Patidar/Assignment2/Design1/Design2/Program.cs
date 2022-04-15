using System;
using IBank.Utility;
namespace IBank.Design2
{
    internal class Program
    {

        public class Account
        {
            public Account() { }  // Account class constructor
            public int AccNo;
            Customer Cust;
            Branch Branch;
            int CurrentBalance;
        }
        public interface IAccount
        {
            //interfaces methods 
            public void OpenAccount();
            public void Close_Account();
            public void Deposit();
        }
        public class SB_Account : Account, IAccount
        {
            //interface methods defination
            public void OpenAccount() { Console.WriteLine("Opening an account of Saving Type"); }
            public void Deposit() { Console.WriteLine("Deposit money in account of Saving Type"); }
            public void Withdraw()
            {
                Console.WriteLine("Withdraw money from account of Saving Type");
            }

            public void Close_Account() { Console.WriteLine("Closing an account of Saving Type"); }
        }

        public class Current_Account : Account, IAccount
        {

            public void OpenAccount() { Console.WriteLine("Opening an account of Current type"); }
            public void Deposit() { Console.WriteLine("Deposit money in account of Current type"); }
            public void Withdraw()
            {
                Console.WriteLine("Withdraw money from account of Current Type");
            }
            public void Close_Account() { Console.WriteLine("Closing an account of Current type"); }
        }
        public class FD_Account : Account, IAccount
        {

            public void OpenAccount() { Console.WriteLine("Opening an account of FD type"); }
            public void Deposit() { Console.WriteLine("Deposit money in account of FD type"); }
            public void Close_Account() { Console.WriteLine("Closing an account of FD type"); }
        }
        public class RD_Account : Account, IAccount
        {

            public void OpenAccount() { Console.WriteLine("Opening an account of RD type"); }
            public void Deposit() { Console.WriteLine("Deposit money in account of RD type"); }
            public void Close_Account() { Console.WriteLine("Closing an account of RD type"); }
        }
        static void Main(string[] args)
        {
            SB_Account sbaccount = new SB_Account();
            sbaccount.OpenAccount();
            sbaccount.Deposit();
            sbaccount.Close_Account();
        }
    }
}
