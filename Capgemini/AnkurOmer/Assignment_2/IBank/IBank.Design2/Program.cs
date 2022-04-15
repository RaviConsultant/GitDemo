using System;
using IBank.Utility;

namespace IBank.Design2
{
    internal class Program
    {
        #region Account class
        public class Account
        {
            public int AccNumber;
            public IBank.Utility.Customer customer;
            public IBank.Utility.Branch branch;
            public double CurrentBalance;
        }
        #endregion Account class

        #region Account Interface
        public interface IAccount 
        {   
            public void OpenAccount();
            public void Deposit();
            public void CloseAccount();
        }
        #endregion Account Interface

        #region SB_Account class
        public class SB_Account : Account, IAccount
        {
            public void OpenAccount() 
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
                if (Amount <= 75.00) 
                {
                    if (CurrentBalance >= 100)
                        CurrentBalance -= Amount;
                    else
                        Console.WriteLine("Minimum Balance should be 100USD");
                }
                else { Console.WriteLine("Withdraw Limit 75 USD"); }
            }

            public void Deposit() { }
            public void CloseAccount() { }
        }

        #endregion SB_Account class


        #region Current_Account class
        public class Current_account : Account, IAccount
        {
            public void OpenAccount() 
            {
                if (base.CurrentBalance >= 500)
                {
                    Console.WriteLine("Current Account Opened");
                }
                else
                {
                    Console.WriteLine("To open Current account please deposit 500 USD");
                }
            }
            public void Deposit() { }
            public void CloseAccount() { }
            public void Withdraw(double Amount)
            {
                if (Amount <= 400.00) {
                    if (CurrentBalance >= 500)
                        CurrentBalance -= Amount;
                    else
                        Console.WriteLine("Minimum Balance should be 500USD");
                }
                else { Console.WriteLine("Withdraw Limit 400 USD"); }
            }
        }

        #endregion Current_Account class

        #region FD_Account class
        public class FD_Account : Account, IAccount
        {
            public void OpenAccount() { Console.WriteLine("Fixed Deposit Account opened"); }
            public void Deposit() { }
            public void CloseAccount() { }
        }

        #endregion FD_Account class

        #region RD_Account class
        public class RD_Account : Account, IAccount
        {
            public void OpenAccount() { Console.WriteLine("RD Account opened"); }
            public void Deposit() { }
            public void CloseAccount() { }
        }

        #endregion RD_Account class

        static void Main(string[] args)
        {
            
        }
    }
}
