using System;
using IBank.Utility;


namespace IBank.Design1
{
    internal class Program
    {
        private static string accountType;

        public abstract class Account
        {
            
            public string AccNo;
            public Customer customer;  
            public Branch branch;
            public double CurrentBalance=0.0;

            public abstract void openAccount(string firstName, string lastName , string city, string phone ,string branchName);
            public void deposit(double amount){
                this.CurrentBalance += amount;
                Console.WriteLine("Current Balance is: "+ CurrentBalance);
            }
        
            public void closeAccount(){
                GC.Collect();
                Console.WriteLine("Account Closed");

            }

        }

        public class SBAccount: Account
        {
            public  override void openAccount(string firstName, string lastName, string city, string phone, string branchName)
            {
               
                if (base.CurrentBalance >= 100)
                { 
                    
                    base.customer = new Customer();
                    base.customer.firstName = firstName;
                    base.customer.lastName = lastName;
                    base.customer.custAdd = new Address();
                    base.customer.custAdd.city = city;
                    base.customer.custContact = new ContactInfo();
                    base.customer.custContact.phone = phone;
                    base.branch = new Branch();
                    base.branch.name = branchName;
                    Console.WriteLine("Account Opened");
                    
                }
                else
                {
                    Console.WriteLine("To open account please deposit 100 USD");
                    Console.WriteLine("\n Enter Amount");
                    double amount= double.Parse(Console.ReadLine());
                    this.deposit(amount);
                    this.openAccount(firstName, lastName, city, phone, branchName);
                }  

            }
            public string withdraw(double amount){

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
            public override void openAccount(string firstName, string lastName, string city, string phone, string branchName) {
                if (base.CurrentBalance >= 500)
                {

                    base.customer = new Customer();
                    base.customer.firstName = firstName;
                    base.customer.lastName = lastName;
                    base.customer.custAdd = new Address();
                    base.customer.custAdd.city = city;
                    base.customer.custContact = new ContactInfo();
                    base.customer.custContact.phone = phone;
                    base.branch = new Branch();
                    base.branch.name = branchName;
                    Console.WriteLine("Account Opened");

                }
                else
                {
                    Console.WriteLine("To open account please deposit 500 USD");
                    Console.WriteLine("\n Enter Amount");
                    double amount = double.Parse(Console.ReadLine());
                    this.deposit(amount);
                    this.openAccount(firstName, lastName, city, phone, branchName);
                }
            }
            public string withdraw(double amount) {
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
            public override void openAccount(string firstName, string lastName, string city, string phone, string branchName) {
                base.customer = new Customer();
                base.customer.firstName = firstName;
                base.customer.lastName = lastName;
                base.customer.custAdd = new Address();
                base.customer.custAdd.city = city;
                base.customer.custContact = new ContactInfo();
                base.customer.custContact.phone = phone;
                base.branch = new Branch();
                base.branch.name = branchName;
                Console.WriteLine("Account Opened");
            }
           
        }
        public class ReccuringDepositAccount : Account
        {
            public override void openAccount(string firstName, string lastName, string city, string phone, string branchName) {
                base.customer = new Customer();
                base.customer.firstName = firstName;
                base.customer.lastName = lastName;
                base.customer.custAdd = new Address();
                base.customer.custAdd.city = city;
                base.customer.custContact = new ContactInfo();
                base.customer.custContact.phone = phone;
                base.branch = new Branch();
                base.branch.name = branchName;
                Console.WriteLine("Account Opened");
            }
           

        }

        static void Main(string[] args)
        {

            try
            {

                double amount;
                string accountType;
                string choice;
                string firstName;
                string lastName;
                string city;
                string phone;
                string branchName;

                    Console.WriteLine(" Press 1 for SbAccount \n Press 2 for Current Account  \n Press 3 for FD Account \n Press 4 for RD Account \n Press 5 to exit");
                    accountType = Console.ReadLine();
                    switch (accountType)
                    {
                        case "1":
                            SBAccount ac = new SBAccount();
                            Console.WriteLine("Enter First Name");
                            firstName = Console.ReadLine();
                            Console.WriteLine("Enter Last Name");
                            lastName = Console.ReadLine();
                            Console.WriteLine("Enter city");
                            city = Console.ReadLine();
                            Console.WriteLine("Enter phone");
                            phone = Console.ReadLine();
                            Console.WriteLine("Enter branch name ");
                            branchName = Console.ReadLine();
                            ac.openAccount(firstName, lastName, city, phone, branchName);
                            do
                            { 
                                Console.WriteLine(" Press 1 to Deposit \n Press 2 to Withdraw \n Press 3 to Close Account \n Press 4 to exit");
                                choice = Console.ReadLine();
                                switch (choice)
                                {
                                
                                    case "1":
                                        Console.WriteLine("Enter amount to be deposited");
                                        amount = double.Parse(Console.ReadLine());
                                        ac.deposit(amount);
                                        break;
                                    case "2":
                                        Console.WriteLine("Enter amount to be withdraw");
                                        amount = double.Parse(Console.ReadLine());
                                        Console.WriteLine(ac.withdraw(amount));
                                       break;


                                    case "3":
                                        ac.closeAccount();
                                        break;
                                    case "4":
                                        break;
                                    default:
                                        Console.WriteLine("Enter a valid choice");
                                        break;

                                }
                            } while (choice != "4");
                            break;
                        case "2":
                            CurrentAccount ca = new CurrentAccount();
                            Console.WriteLine("Enter First Name");
                            firstName = Console.ReadLine();
                            Console.WriteLine("Enter Last Name");
                            lastName = Console.ReadLine();
                            Console.WriteLine("Enter city");
                            city = Console.ReadLine();
                            Console.WriteLine("Enter phone");
                            phone = Console.ReadLine();
                            Console.WriteLine("Enter branch name ");
                            branchName = Console.ReadLine();
                            ca.openAccount(firstName, lastName, city, phone, branchName);
                         do
                            {
                                Console.WriteLine(" Press 1 to Deposit \n Press 2 to Withdraw \n Press 3 to Close Account \n Press 4 to exit");
                                choice = Console.ReadLine();
                                switch (choice)
                                {
                                  
                                    case "1":
                                        Console.WriteLine("Enter amount to be deposited");
                                        amount = double.Parse(Console.ReadLine());
                                        ca.deposit(amount);
                                        break;
                                    case "2":
                                        Console.WriteLine("Enter amount to be withdraw");
                                        amount = double.Parse(Console.ReadLine());
                                        Console.WriteLine(ca.withdraw(amount));
                                        break;
                                    case "3":
                                        ca.closeAccount();
                                        break;
                                    case "4":
                                        break;
                                    default:
                                        Console.WriteLine("Enter a valid choice");
                                        break;

                                }
                            } while (choice != "4");
                            break;
                        case "3":
                            FixedDepositAccount fa = new FixedDepositAccount();
                            Console.WriteLine("Enter First Name");
                            firstName = Console.ReadLine();
                            Console.WriteLine("Enter Last Name");
                            lastName = Console.ReadLine();
                            Console.WriteLine("Enter city");
                            city = Console.ReadLine();
                            Console.WriteLine("Enter phone");
                            phone = Console.ReadLine();
                            Console.WriteLine("Enter branch name ");
                            branchName = Console.ReadLine();
                            fa.openAccount(firstName, lastName, city, phone, branchName);
                        do
                            {
                                Console.WriteLine(" Press 1 to Deposit \n Press 2 to Close Account \n Press 3 to exit ");
                                choice = Console.ReadLine();
                                switch (choice)
                                {
                                    case "1":
                                        Console.WriteLine("Enter amount to be deposited");
                                        amount = double.Parse(Console.ReadLine());
                                        fa.deposit(amount);
                                        break;
                                    case "2":
                                        fa.closeAccount();
                                        break;
                                    case "3":
                                        break;
                                    default:
                                        Console.WriteLine("Enter a valid choice");
                                        break;

                                }
                            } while (choice != "3");
                            break;
                        case "4":
                            ReccuringDepositAccount ra = new ReccuringDepositAccount();
                           Console.WriteLine("Enter First Name");
                           firstName = Console.ReadLine();
                           Console.WriteLine("Enter Last Name");
                           lastName = Console.ReadLine();
                           Console.WriteLine("Enter city");
                           city = Console.ReadLine();
                           Console.WriteLine("Enter phone");
                           phone = Console.ReadLine();
                           Console.WriteLine("Enter branch name ");
                           branchName = Console.ReadLine();
                           ra.openAccount(firstName, lastName, city, phone, branchName);
                        do
                            {
                                Console.WriteLine(" Press 1 to Deposit \n Press 2 to Close Account \n Press 3 to exit ");
                                choice = Console.ReadLine();
                                switch (choice)
                                {
                                    case "1":
                                        Console.WriteLine("Enter amount to be deposited");
                                        amount = double.Parse(Console.ReadLine());
                                        ra.deposit(amount);
                                        break;
                                    case "2":
                                        ra.closeAccount();
                                        break;
                                    case "3":
                                        break;
                                    default:
                                        Console.WriteLine("Enter a valid choice");
                                        break;
                                }
                            } while (choice != "3");
                            break;

                        case "5":
                            break;
                        default:
                            Console.WriteLine("Choose valid account type");
                            break;
                    }

            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.ToString());
            }
        }
       
    }
}