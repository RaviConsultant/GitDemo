using System;
using IBank.Utility;

namespace IBank.Design1
{
    internal class Program
    {
        #region Account class
        public abstract class Account
        {
            public int AccNumber;
            public IBank.Utility.Customer customer;
            public IBank.Utility.Branch branch;
            public double CurrentBalance;
            public abstract void OpenAccount();
            public void Deposit() { }
            public void CloseAccount() { }
        }
        #endregion Account class

        #region SBAccount 
        public class SB_Account : Account
        {
            public override void OpenAccount() 
            {
                if (base.CurrentBalance >= 100)
                {
                    Console.WriteLine("SB Account Opened");
                }
                else
                {
                    Console.WriteLine("To open SB account please deposit 100 USD");
                }
            }
            public void Withdraw(double Amount)
            {
                if (Amount <= 75.00) {
                    if (CurrentBalance >= 100)
                        CurrentBalance -= Amount;
                    else
                        Console.WriteLine("Minimum Balance should be 100USD");
                }
                else { Console.WriteLine("Withdraw Limit 75 USD"); }
            }
        }
        #endregion SBAccount 

        #region CurrentAccount class
        public class Current_account: Account
        {
            public override void OpenAccount() {
                if (base.CurrentBalance >= 500)
                {
                    Console.WriteLine("Current Account Opened");
                }
                else
                {
                    Console.WriteLine("To open current account please deposit 500 USD");
                }
            }
            public void Withdraw(double Amount)
            {
                if (Amount <= 400.00) {
                    if (CurrentBalance >= 500)
                        CurrentBalance -= Amount;
                    else
                        Console.WriteLine("Minimum Balance should be 100USD");
                }
                else { Console.WriteLine("Withdraw Limit 400 USD"); }
            }
        }
        #endregion CurrentAccount class

        #region FD_Account class
        public class FD_Account: Account
        {
            public override void OpenAccount() { Console.WriteLine("Fixed Account opened"); }
        }
        #endregion FD_Account class

        #region RD_Account class
        public class RD_Account: Account
        {
            public override void OpenAccount() { Console.WriteLine("RD Account opened"); }
        }
        #endregion RD_Account class


        static void Main(string[] args)
        {
            SB_Account A = new SB_Account();
            A.AccNumber = 100010;
            A.customer.FirstName = "Eren";
            A.customer.LastName = "Yeager";
            A.customer.ContactInfo.Phone = 9998887770;
            A.OpenAccount();

            Console.WriteLine("Hello World!");
        }
    }
}
