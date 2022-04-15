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

            public abstract void openAccount();
            public virtual void deposit(){}
            public void closeAccount(){}

        }

        public class SBAccount: Account
        {
            public override void openAccount()
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
            public string withdraw(int amount){
                if(amount>75)
                {
                    return "Withdraw limit is 75 USD/trans";
                }
                else if(CurrentBalance-amount>100)
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
            public override void openAccount() {
                if (base.CurrentBalance >= 500)
                {
                    Console.WriteLine("Account Opened");
                }
                else
                {
                    Console.WriteLine("To open account please deposit 500 USD");
                }
            }
            public string withdraw(int amount) {
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
        public class FixedDepositAccount : Account
        {
            public override void openAccount(){}
           
        }
        public class ReccuringDepositAccount : Account
        {
            public override void openAccount() {}
            public override void deposit() {}

        }

        static void Main(string[] args)
        {

        }
    }
}