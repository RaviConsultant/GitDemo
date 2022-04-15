using System;

namespace Utility_opps_2_1
{
    public class Contact
    {
        public uint phone = 989397349;
        public uint mobile = 98765444;
        public String email = "yashjain9800@gmail.com";
    }
    public class Address
    {
        public String street = "Street";
        public String city = "Indore";
        public String area = "Bhavarkua";
        public int zip = 452001;
    }
    public class Customer
    {
        Address addre;
        Contact contact;

        public void Address()
        {
            Console.WriteLine();
            Console.WriteLine("City:- " + addre.city);
            Console.WriteLine("Street:- " + addre.street);
            Console.WriteLine("Area:- " + addre.area);
            Console.WriteLine("Zip:- " + addre.zip);
        }
        public void contachinfo()
        {
            Console.WriteLine();
            Console.WriteLine("Phone:- " + contact.phone);
            Console.WriteLine("Mobile:- " + contact.mobile);
            Console.WriteLine("Email:- " + contact.email);
        }
        public void First_Name()
        {
            string first = "Yash";
            Console.WriteLine("Your first name is " + first);

        }
        public void Last_name()
        {
            string last = "Jain";
            Console.WriteLine("Your first name is " + last);
        }
    }
    public class Branch : Customer
    {

        public string Name = "Yash Jain";



    }
    public class sb_account
    {
        //Account account = new Account();

        public void withdraw(int num, int limit)
        {
            if (num > limit)
            {
                Console.WriteLine($"Sorry for your inconvinience but our acc limit is {limit}");
            }
            else
            {
                //account.currentbalance = account.currentbalance - num;
                Console.WriteLine($"{num} has been deducted from your acc...");
            }
        }
    }
    public class FD_account
    {
        //public int current = 1000;
        //Account account = new Account();
        public void deposit(int num)
        {
            //account.currentbalance = account.currentbalance + num;
            Console.WriteLine($"{num} USD has been deposited");
        }
    }
    public class RD_account
    {
        //Account account = new Account();
        //public int current = 1000;
        public void deposit(int num)
        {
            //account.currentbalance = account.currentbalance + num;
            Console.WriteLine($"{num} USD has been deposited");
        }
    }
    public class cr_account
    {
        //public int current = 1000;
        //Account account = new Account();
        public void deposit(int num)
        {
            //account.currentbalance = account.currentbalance + num;
            Console.WriteLine($"{num} USD has been deposited");
        }
        public void withdraw(int num, int limit)
        {
            if (num > limit)
            {
                Console.WriteLine($"Sorry for your inconvinience but our acc limit is {limit}");
            }
            else
            {
                //account.currentbalance = account.currentbalance + num;
                Console.WriteLine($"{num} has been deducted from your acc...");
            }
        }
    }


}
