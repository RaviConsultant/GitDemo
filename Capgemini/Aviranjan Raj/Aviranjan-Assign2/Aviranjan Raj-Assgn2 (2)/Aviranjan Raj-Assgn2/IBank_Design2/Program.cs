using System;
using IBank.Utility;

namespace IBank.Design2
{
    internal class Program
    {
        public class Account
        {
            Customer customer;
            Branch branch;
            public string AccNum;
            public double CurrentBalance;

        }
        public interface IAccount
        {
            public void OpenAccount();
            public  void deposit();
            public void closeAccount();
        }

        public class SBAccount :  Account , IAccount
        {
            public void OpenAccount()
            {
                if (base.CurrentBalance >= 100)
                {
                    Console.WriteLine("Account is Opened");
                }
                else
                {
                    Console.WriteLine("For opening the account please deposit 100 USD");
                }


            }
            public void deposit() {}
            public void OpenAccount() {}

            public string withdraw(int amount)
            {
                if (amount > 75)
                {
                    return "Withdraw limit is 75 USD/trans";
                }
                else if (CurrentBalance - amount > 100)
                {
                    CurrentBalance = CurrentBalance - amount;
                    return "Current Balance is " + CurrentBalance;

                }
                else
                {
                    return "We have to maintain a minimum balance of 100 USD";
                }
            }

        }
        public class CurrentAccount : Account ,IAccount
        {
            public  void OpenAccount()
            {
                if (base.CurrentBalance >= 500)
                {
                    Console.WriteLine("Account Opened");
                }
                else
                {
                    Console.WriteLine("To open account please deposit 500 USD");
                }
            }
            public void deposit() { }
            public void closeAccount() { }
            public string withdraw(int amount)
            {
                if (amount > 400)
                {
                    return "Withdraw limit is 75 USD/trans";
                }
                else if (CurrentBalance - amount > 500)
                {
                    CurrentBalance = CurrentBalance - amount;
                    return "Current Balance is " + CurrentBalance;

                }
                else
                {
                    return "We need to maintain a minimum balance of 500 USD";
                }
            }

        }
        public class FixedDepositAccount : Account,IAccount
        {
            public  void OpenAccount() { }
            public void deposit() { }
            public void closeAccount() { }

        }
        public class ReccuringDepositAccount : Account, IAccount
        {
            public  void OpenAccount() { }
            public  void deposit() { }
            public void closeAccount() { }

        }
        static void Main(string[] args)
        {


        }
    }

}