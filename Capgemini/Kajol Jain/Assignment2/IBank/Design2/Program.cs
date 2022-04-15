using System;
using Utility;

namespace Design2
{
    internal class Program
    {
        /// <summary>
        /// Implementing IAccount interface 
        /// </summary>
        class Account : IAccount
        {
            public double currentBalance;
            public int accNo = 0;

            //reference of Customer and Branch structure
            Customer customer;
            Branch branch;

            //overriding method of interface
            public void closeAccount()
            {
                Console.WriteLine("Account Closed");
                //throw new NotImplementedException();
            }

            //overriding method of IAccount
            public void deposit(double amount)
            {
                Console.WriteLine("Availabe Balance:" + (currentBalance + amount));
            }
            //overriding method of IAccount
            public void openAccount(double amount)
            {
                Console.WriteLine("Congratulations!!Account Opened..");
                Console.WriteLine("Current Balance is:" + (currentBalance += amount));

                //throw new NotImplementedException();
            }

            //method to set values of structure 
            public void setValues()
            {
                customer = new Customer();
                branch = new Branch();

                //assigning values to structure variables
                customer.FirstName = "Ram";
                customer.LastName = "Kumar";
                customer.address.City = "Delhi";
                customer.address.Area = "Palasia";
                customer.address.Street = "13a";
                customer.address.Zip = 123456;

                customer.contactInfo.Phone = 9865432345;
                customer.contactInfo.Email = "abc@gmail.com";
                customer.contactInfo.Mobile = 9876543211;

                branch.Name = "Palasia branch";
            }

            //method to display  structure variable values
            public void display()
            {
                Console.WriteLine(customer.FirstName);
                Console.WriteLine(customer.LastName);
                Console.WriteLine(customer.address.City);
                Console.WriteLine(customer.address.Area);
                Console.WriteLine(customer.address.Street);
                Console.WriteLine(customer.address.Zip);
                Console.WriteLine(customer.contactInfo.Phone);
                Console.WriteLine(customer.contactInfo.Email);
                Console.WriteLine(customer.contactInfo.Mobile);

            }

            public void openAccount1(double amount)
            {
                throw new NotImplementedException();
            }

            public void closeAccount1()
            {
                throw new NotImplementedException();
            }

            public void deposit1(double amount)
            {
                throw new NotImplementedException();
            }
        }
            static void Main(string[] args)
        {
           
            Console.WriteLine("Hello World!");

            //creating object of class Account
            Account account = new Account();

            //calling method of class Account by its object
            account.setValues();
            account.display();
            account.openAccount(300);
            account.deposit(500);
            account.closeAccount();

        }
    }
}
