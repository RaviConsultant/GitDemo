using System;
using IBank.utility;

namespace IBank.Design_2
{
    internal class Program
    {
        /// <summary>
        /// Account class declaration 
        /// </summary>
        public class Account
        {

            public string AccNo;
            Customer customer;
            Branch branch;
            public double MinBalance;

        }

        /// <summary>
        /// Interface Created 
        /// </summary>
        public interface IAccount
        {
            public void OpenAccount(double Balance);
            public void Deposit();
            public void CloseAccount();
        }

        /// <summary>
        /// SBAccount class interhites the account class and IAccount Interface
        /// </summary>
        public class SBAccount : Account, IAccount
        {
            /// <summary>
            /// function for opening account
            /// </summary>
            public void OpenAccount(double Balance)
            {
                // setting the MinBalance Value
                this.MinBalance = Balance;
                // checking if currentBalance is sufficient or not for creating account
                if (Balance >= 100)
                {
                    Console.WriteLine("Account Opened"+" Your Current Balance is "+MinBalance);
                }
                else
                {
                    Console.WriteLine("To open account please deposit 100 USD");
                }

            }

            /// <summary>
            /// method for Withdraw
            /// </summary>
            /// <param name="amount"></param>
            /// <returns></returns>
            public string Withdraw(int amount)
            {
                // checking if amount is sufficient or not for withdraw
                if (amount > 75)
                {
                    return "Withdraw limit is 75 USD/trans";
                }
                else if (MinBalance - amount > 100)
                {
                    
                    MinBalance = MinBalance - amount;
                    //returning current Balace from account
                    return "Current Balance is " + MinBalance;

                }
                else
                {
                    return "We need to maintain a minimum balance of 100 USD";
                }
            }

            public void Deposit()
            {
                Console.WriteLine("Amount Deposit");
            }
            public void CloseAccount()
            {
                Console.WriteLine("Account Closed!!");
            }

        }


        // CurrentAccount class implemets Account and IAccount
        public class CurrentAccount : Account, IAccount
        {
            /// <summary>
            /// function for opening account
            /// </summary>
            public void OpenAccount(double Balance)
            {
                //setting the MinBalance value
                this.MinBalance = Balance;
                // checking if currentbalance is sufficient for opening account or not
                if (Balance >= 500)
                {
                    Console.WriteLine("Account Opened!"+" Your Current Balace is "+MinBalance);
                }
                else
                {
                    Console.WriteLine("To open account please deposit 500 USD");
                }
            }

            /// <summary>
            /// method for Withdraw
            /// </summary>
            /// <param name="amount"></param>
            /// <returns></returns>
            public string Withdraw(int amount)
            {
                //checking if the amount is sufficient or not for withdraw
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

            public void Deposit()
            {
                Console.WriteLine("Amount Deposit");
            }
            public void CloseAccount()
            {
                Console.WriteLine("Account Closed!!");
            }


        }

        // FixedDepositAccount class implemets Account and IAccount
        public class FixedDepositAccount : Account, IAccount
        {
            public void OpenAccount(double Balance) 
            {
                this.MinBalance=Balance;
                Console.WriteLine("Account Opened!"+ "your Current Balance is " + MinBalance);
            }
            public void Deposit()
            {
                Console.WriteLine("Amount Deposit");
            }
            public void CloseAccount() 
            {
                Console.WriteLine("Account closed!!");
            }

        }

        // ReccuringDepositAccount class implemets Account and IAccount
        public class ReccuringDepositAccount : Account, IAccount
        {
            public void OpenAccount(double Balance) {
                this.MinBalance = Balance;
                Console.WriteLine("Account Opened!"+"your Current Balance is "+MinBalance); 
            }
            public void Deposit()
            {
                Console.WriteLine("Amount Deposit");
            }
            public void CloseAccount() {
                Console.WriteLine("Account closed!!");
            }

        }

        static void Main(string[] args)
        {
            // creating instance of SBAccount

            SBAccount acc1 = new SBAccount();

            //calling methods for SBAccount
            acc1.OpenAccount(550);
            acc1.Deposit();
            Console.WriteLine(acc1.Withdraw(50));
            acc1.CloseAccount();

            //// creating Instance of CurrentAccount 
            //CurrentAccount acc1 = new CurrentAccount();

            ////calling methods for CurrentAccount
            //acc1.OpenAccount(900);
            //acc1.Deposit();
            //Console.WriteLine(acc1.Withdraw(60));
            //acc1.CloseAccount();


            //creating instance of FixedDepositAccount 
            //FixedDepositAccount acc1 = new FixedDepositAccount();

            ////calling methods for FixedDepositAccount
            //acc1.OpenAccount(400);
            //acc1.Deposit();
            //acc1.CloseAccount();


            ////creating instance of ReccuringDepositAccount
            //ReccuringDepositAccount acc1 = new ReccuringDepositAccount();

            //calling mmethods for ReccuringDepositAccount
            //acc1.OpenAccount(1000);
            //acc1.Deposit();
            //acc1.CloseAccount();



        }
    }
}
