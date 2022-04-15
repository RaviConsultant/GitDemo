using System;
using IBank.Utility;


namespace IBank.Design1
{
    internal class Program
    {
        public abstract class Account
        {

            public string AccNo;
            Customer customer;
            Branch branch;
            public double CurrentBalance;

            public abstract void OpenAccount();
            public virtual void Deposit() { }
            public void CloseAccount() { }

        }

        public class SBAccount : Account
        {
            public override void OpenAccount()
            {
                if (base.CurrentBalance >= 100)
                {
                    Console.WriteLine("Account Opened");
                }
                else
                {
                    Console.WriteLine("To open account please deposit 100 USD");
                }


            }
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
                    return "We need to maintain a minimum balance of 100 USD";
                }
            }

        }
        public class CurrentAccount : Account
        {
            public override void OpenAccount()
            {
                if (base.CurrentBalance >= 500)
                {
                    Console.WriteLine("Account Opened");
                }
                else
                {
                    Console.WriteLine("  Note that to open account please deposit 500 USD");
                }
            }
            public string withdraw(int amount)
            {
                if (amount > 400)
                {
                    return "Withdraw limit is  75 USD Only for a transaction";
                }
                else if (CurrentBalance - amount > 500)
                {
                    CurrentBalance = CurrentBalance - amount;
                    return "Current Balance is " + CurrentBalance;
                }
                else
                {
                    return "Ensure Minimum balance of 500 USD ";
                }
            }

        }

        public class ReccuringDepositAccount : Account
        {
            public override void OpenAccount() { }
            public override void Deposit() { }
        }
        public class FixedDepositAccount : Account
        {
            public override void OpenAccount() { }

        }

        static void Main(string[] args)
        {

        }
    }
}