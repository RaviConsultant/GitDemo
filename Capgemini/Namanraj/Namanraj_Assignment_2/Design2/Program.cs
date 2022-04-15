using System;
using IBank.Utility1;
namespace IBank_Design2
{
    internal class Program
    {

        public abstract class Account// declaring an abstract class of Account
        {
            public Account() { }
            public int AccNo;
            Customer Cust;
            Branch Branch;
            int CurrentBalance;
        }
        public interface IAccount
        {
            public void OpenAccount();
            public void Close_Account();
            public void Deposit();
        }
        public class SB_Account : Account, IAccount
        //multiple inheritance 
        {

            public void OpenAccount() 
            {
                Console.WriteLine("Opening an account of Saving Type");
            }
            public void Deposit() 
            { 
                Console.WriteLine("Deposit money in account of Saving Type"); 
            }
            public void Withdraw()
            {
                Console.WriteLine("Withdraw money from account of Saving Type");
            }

            public void Close_Account() 
            { 
                Console.WriteLine("Closing an account of Saving Type");
            }
        }

        public class Current_Account : Account, IAccount
        {

            public void OpenAccount() 
            { 
                Console.WriteLine("Opening an account of Current type"); 
            }
            public void Deposit() 
            { 
                Console.WriteLine("Deposit money in account of Current type"); 
            }
            public void Withdraw()
            {
                Console.WriteLine("Withdraw money from account of Current Type");
            }
            public void Close_Account()
            { 
                Console.WriteLine("Closing an account of Current type");
            }
        }
        public class FD_Account : Account, IAccount// implementing multiple inheritance 
        {

            public void OpenAccount()
            {
                Console.WriteLine("Opening an account of FD type"); 
            }
            public void Deposit() 
            { 
                Console.WriteLine("Deposit money in account of FD type"); 
            }
            public void Close_Account() 
            { 
                Console.WriteLine("Closing an account of FD type");
            }
        }
        public class RD_Account : Account, IAccount// implementing multiple inheritance in RD_Account class
        {

            public void OpenAccount() 
            { 
                Console.WriteLine("Opening an account of RD type"); 
            }
            public void Deposit() 
            { 
                Console.WriteLine("Deposit money in account of RD type"); 
            }
            public void Close_Account() 
            { 
                Console.WriteLine("Closing an account of RD type");
            }
        }
        static void Main(string[] args)
        {  
            //Saving Bank account
            SB_Account sbaccount = new SB_Account();
            sbaccount.OpenAccount();
            sbaccount.Deposit();
            sbaccount.Withdraw();
            sbaccount.Close_Account();

            // Current account
            Current_Account cuaccount = new Current_Account();
            cuaccount.OpenAccount();
            cuaccount.Deposit();
            cuaccount.Withdraw();
            cuaccount.Close_Account();

            //FD account
            FD_Account fdaccount = new FD_Account();
            fdaccount.OpenAccount();
            fdaccount.Deposit();
            fdaccount.Close_Account();

            // RD account
            RD_Account rdaccount = new RD_Account();
            rdaccount.OpenAccount();
            rdaccount.Deposit();

            rdaccount.Close_Account();
        }
    }
}
