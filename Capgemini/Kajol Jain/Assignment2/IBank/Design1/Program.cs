using System;
using Utility;

namespace Design1
{
    internal class Program
    {
        /// <summary>
        /// abstract class contains only method that have no body
        /// abstract class to declare classes and properties
        /// </summary>
        public abstract class Account
        {
            public double currentBalance;
            public int accNo = 0;

            //Customer and Branch is structure is reference declared in Utility 
            Customer customer;
            Branch branch;

            //abstract method to override in child class
            public abstract void openAccount(double amount);

            public abstract void closeAccount();
            public abstract void deposit(double amount);

            //virtual method to override in child class 
            public virtual void Withdraw(double amount) { }

           // public virtual void setDetails() { }

        }

        //childclass SbAccount inheriting Abstract class Account 
        public class SbAccount : Account
        {

            //override method of Account class 
            //method to deposit amount
            public override void deposit(double amount)
            {
                Console.WriteLine("Current Balance after deposit is:" + (base.currentBalance += amount));
                //throw new NotImplementedException();
            }

            //override method of Account class 
            //method to open account

            public override void openAccount(double amount)
            {

                try
                {
                    //open sb account if amount is >=100
                    if (amount >= 100 )
                    {
                        Console.WriteLine("Congratulations!!Account Opened");
                        Console.WriteLine("Account number is:" + base.accNo + 1);
                        Console.WriteLine("Current Balance is:" + (base.currentBalance += amount));

                    }

                    //else print error
                    else
                    {
                        Console.WriteLine("Please deposit minimum 100 USD to open SB account");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Amount cant be zero");
                }
               
            }

        


            //overrided method to close account
        public override void closeAccount()
        {
            Console.WriteLine("Account Closed");
        }

            //virtual method to withdraw amount 
        public virtual void Withdraw(double amount)
        {
                //withdraw amount if greate than itz limit
            if (amount >= 75)
            {
                Console.WriteLine(" Balance after Withdraw is:" + (base.currentBalance -= amount));
            }
            else
            {
                Console.WriteLine("Minimum 75 can be withdrawn");
            }

        }



    }

        //inheriting Account class to override methods 
    class CurrentAccount : Account
    {
            //overriding openaccount method of Account class
        public override void openAccount(double amount)
        {

            if (amount >= 500)
            {
                Console.WriteLine("Congratulations!!Account Opened");
                    Console.WriteLine("Account number is:" + base.accNo + 1);
                    Console.WriteLine("Current Balance is:" + (base.currentBalance += amount));

                }

                else
            {
                Console.WriteLine("Please deposit minimum 500 USD to open Current account");
            }

            
        }
            //overriding deposit()
        public override void deposit(double amount)
        {

            Console.WriteLine("Current Balance after deposit is:" + (base.currentBalance += amount));

        }

            //overriding method of Account class
        public override void closeAccount()
        {
            Console.WriteLine("Account Closed");
        }

        public virtual void Withdraw(double amount)
        {
            if (amount >= 400)
            {
                Console.WriteLine(" Balance after Withdraw is:" + (base.currentBalance -= amount));
            }
            else
            {
                Console.WriteLine("Minimum 400 can be withdrawn");
            }
        }
    }
        //inheriting Account class to override methods
        class FDAccount : Account
        {
            //overriding method to open account
            public override void openAccount(double amount)
            {

                Console.WriteLine("Congratulations!!Account Opened");




                //printing account number and available balance

                Console.WriteLine("Account number is:" + base.accNo + 1);
                Console.WriteLine("Current Balance is:" + (base.currentBalance += amount));

            }

            public override void deposit(double amount)
            {

                Console.WriteLine("Current Balance after deposit is:" + (base.currentBalance += amount));

            }


            public override void closeAccount()
            {
                Console.WriteLine("Account Closed");
            }

        }
        
        
        //inheriting Account class to override methods
       
        class RDAccount : Account
    {
            //overriding method
            public override void openAccount(double amount)
        {

            Console.WriteLine("Congratulations!!Account Opened");

            Console.WriteLine("Account number is:" + base.accNo + 1);
            Console.WriteLine("Current Balance is:" + (base.currentBalance += amount));

        }
            //overriding method
        public override void deposit(double amount)
        {

            Console.WriteLine("Current Balance after deposit is:" + (base.currentBalance += amount));

        }

            //overriding method
            public override void closeAccount()
        {
            Console.WriteLine("Account Closed");
        }



    }
        
         
    static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //creating ref of Account class
            Account account;

            //choices for user
            Console.WriteLine("1.Open Account");
            Console.WriteLine("2.Deposit amount");
            Console.WriteLine("3.Withdraw");
            Console.WriteLine("4.Close Account");

            //taking input of user choice
            Console.WriteLine("ENter your Choice:");
            //converting string to integer
            int ch = Convert.ToInt32(Console.ReadLine());


            //as per user choice giving more options to user related to account
            switch (ch)
            {
                case 1:
                    Console.WriteLine("1.Open Savings Account (Minimum amount to be maintain is 100 USD)");
                    Console.WriteLine("2.Open Current Account (Minimum amount to be maintain is 500 USD)");
                    Console.WriteLine("3.Open Fixed Deposit Account");
                    Console.WriteLine("4.Open Recurring Deposit Account");

                    Console.WriteLine("Enter choice:");
                    int ch1 = Convert.ToInt32(Console.ReadLine());

                    //As per user choice performing action by taking user input as choice and amount
                    if (ch1 == 1)
                    {
                        account = new SbAccount();
                        Console.WriteLine("Enter amount to get account opened");
                        double amount = Convert.ToDouble(Console.ReadLine());
                        account.openAccount(amount);
                    }
                    else if (ch1 == 2)
                    {
                        account = new CurrentAccount();
                        Console.WriteLine("Enter amount to get account opened");
                        double amount = Convert.ToDouble(Console.ReadLine());
                        account.openAccount(amount);
                    }
                    else if (ch1 == 3)
                    {
                        account = new FDAccount();
                        Console.WriteLine("Enter amount to get account opened");
                        double amount = Convert.ToDouble(Console.ReadLine());
                        account.openAccount(amount);
                    }
                    else if (ch == 4)
                    {
                        account = new RDAccount();
                        Console.WriteLine("Enter amount to get account opened");
                        double amount = Convert.ToDouble(Console.ReadLine());
                        account.openAccount(amount);
                    }
                    //breaking out of particular case
                    break;
                case 2:
                    Console.WriteLine("1.Deposit into Savings Account");
                    Console.WriteLine("2.Deposit into Account");
                    Console.WriteLine("3.Deposit into Fixed Deposit Account");
                    Console.WriteLine("4.Deposit into Recurring Deposit Account");

                    Console.WriteLine("Enter choice:");
                    int ch2 = Convert.ToInt32(Console.ReadLine());
                    //checking user choice
                    if (ch2 == 1)
                    {
                        account = new SbAccount();
                        Console.WriteLine("Enter amount to deposit ");
                        double amount = Convert.ToDouble(Console.ReadLine());
                        account.deposit(amount);
                    }
                    else if (ch2 == 2)
                    {
                        account = new CurrentAccount();
                        Console.WriteLine("Enter amount to deposit");
                        double amount = Convert.ToDouble(Console.ReadLine());
                        account.deposit(amount);
                    }
                    else if (ch2 == 3)
                    {
                        account = new FDAccount();
                        Console.WriteLine("Enter amount to deposit");
                        double amount = Convert.ToDouble(Console.ReadLine());
                        account.deposit(amount);
                    }
                    else if (ch2 == 4)
                    {
                        account = new RDAccount();
                        Console.WriteLine("Enter amount to deposit");
                        double amount = Convert.ToDouble(Console.ReadLine());
                        account.deposit(amount);
                    }
                    break;
                case 3:
                    {
                        Console.WriteLine("1.Withdraw from Savings Account");
                        Console.WriteLine("2.Withdraw from Current Account");
                        Console.WriteLine("3. No Withdraw from Fixed Deposit Account");
                        Console.WriteLine("4.No Withdraw from Recurring Deposit Account");

                        Console.WriteLine("Enter choice:");
                        int ch3 = Convert.ToInt32(Console.ReadLine());

                        if (ch3 == 1)
                        {
                            account = new SbAccount();
                            Console.WriteLine("Enter amount to withdraw");
                            double amount = Convert.ToDouble(Console.ReadLine());
                            account.Withdraw(amount);
                        }
                        else if (ch3 == 2)
                        {
                            account = new CurrentAccount();
                            Console.WriteLine("Enter amount to withdraw");
                            double amount = Convert.ToDouble(Console.ReadLine());
                            account.Withdraw(amount);
                        }

                        else if (ch3 == 3 || ch3 == 4)
                        {
                            Console.WriteLine("3. No Withdraw ");
                            break;
                        }
                    }
                    break;
                case 4:
                    {
                        Console.WriteLine("1.Close Savings Account");
                        Console.WriteLine("2.Close Current Account");
                        Console.WriteLine("3. Close Fixed Deposit Account");
                        Console.WriteLine("4.Close Recurring Deposit Account");

                        Console.WriteLine("Enter choice:");
                        int ch3 = Convert.ToInt32(Console.ReadLine());

                        if (ch3 == 1)
                        {
                            account = new SbAccount();

                            account.closeAccount();
                        }
                        else if (ch3 == 2)
                        {
                            account = new CurrentAccount();
                            account.closeAccount();
                        }
                        else if (ch3 == 3)
                        {
                            account = new FDAccount();
                            account.closeAccount();
                        }
                        else
                        {
                            account = new RDAccount();
                            account.closeAccount();
                        }
                    }
                    break;



            }


        }
    }
}
