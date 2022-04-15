using System;
using IBank.utility;

namespace Design_1
{
    internal class Program
    {
        //defining abstract class Account
        public abstract class Account
        {

            public int AccNo;
            Customer customer;
            Branch branch;
            public double MinBalance;

            //defining abstract method
            public abstract void OpenAccount(double Balance);

            // defining virtual method
            public virtual void Deposit() { }
            public void CloseAccount() { }

        }

        // SBAccount inheriting Account class
        public class SBAccount : Account
        {
            /// <summary>
            /// method for opening accont
            /// </summary>
            /// <param name="Balance"></param>
            public override void OpenAccount(double Balance)
            {
                //checking currentbalance is sufficient or not to open a account
                if (Balance >= 100)
                {
                    Console.WriteLine("Account Opened!");
                }
                else
                {
                    Console.WriteLine("To open account please deposit 100 USD");
                }
            }
            /// <summary>
            /// Withdraw method
            /// </summary>
            /// <param name="amount"></param>
            /// <returns></returns>
            public string  Withdraw(int amount)
            {
                //checking amount is sufficient for withdrawing or not
                if (amount > 75)
                {
                     return "Withdraw limit is 75 USD/trans";
                }
                else if (MinBalance - amount > 100)
                {
                    
                    MinBalance = MinBalance - amount;
                    //returning current Balace from account
                    return "Minimum Balance is " + MinBalance;

                }
                else
                {
                    return "We need to maintain a minimum balance of 100 USD";
                }
            }

            // CurrentAccount class inheriting Account class
            public class CurrentAccount : Account
            {
                /// <summary>
                /// Overriding OpenAccont
                /// </summary>
                /// <param name="Balance"></param>
                public override void OpenAccount(double Balance)
                {
                    //checking current balance
                    if (Balance >= 500)
                    {
                        Console.WriteLine("Account Opened");
                    }
                    else
                    {
                        Console.WriteLine("To open account please deposit 500 USD");
                    }
                }

                /// <summary>
                /// Withdraw method
                /// </summary>
                /// <param name="amount"></param>
                /// <returns></returns>
                public string  Withdraw(int amount)
                {
                    //checking amount is sufficient for withdrawing or not
                    if (amount > 400)
                    {
                        return "Withdraw limit is 75 USD/trans";
                    }
                    else if (MinBalance - amount > 500)
                    {
                        MinBalance = MinBalance - amount;
                        //returning current Balace from account
                        return "Current Balance is " + MinBalance;

                    }
                    else
                    {
                       return "We need to maintain a minimum balance of 500 USD";
                    }
                }

            }

            // FixedDepositAccount inheriting Account class
            public class FixedDepositAccount : Account
            {
                /// <summary>
                /// overridding openAccount function
                /// </summary>
                public override void OpenAccount(double Balance) {
                    Console.WriteLine("Account Opened!");
                }

                /// <summary>
                /// overriding Deposit function
                /// </summary>
                public override void Deposit()
                {
                    Console.WriteLine("Amount Deposit");
                }
                

            }

            // ReccuringDepositAccount inheriting Account class
            public class ReccuringDepositAccount : Account
            {
                /// <summary>
                /// overriding OpenAccount function
                /// </summary>
                public override void OpenAccount(double Balance) 
                {
                    Console.WriteLine("Account Opened!");
                }

                /// <summary>
                /// overriding Deposit function
                /// </summary>
                public override void Deposit() 
                {
                    Console.WriteLine("Amount Deposit");
                }

            }

        }
        static void Main(string[] args)
        {
  
        }
    }
}
