using System;

namespace IBank.Utility{
    public class Account{
        public void Account_Number(){
            Console.WriteLine(" Your Account no. is : 2002365445");
        }
        public void OpenAccount(){
            Console.WriteLine("Account Opened Successfully !!");
        }

        public void CloseAccount(){
            Console.WriteLine("Account Closed ....");
        }
    }
    interface Contact{
        void Contact();
       
    }
    interface Address{
        void Address();

    }

    
    public class Customer : Contact, Address, Branch{
        public void Address(){
            Console.WriteLine();
            Console.WriteLine("Enter Your Address: ");
            Console.Write("City:- ");
            String city = Console.ReadLine();
            Console.Write("Street:- ");
            String street = Console.ReadLine();
            Console.Write("Area:- ");
            String area = Console.ReadLine(); 
            Console.Write("Zip:- ");
            String zip = Console.ReadLine();
        }
        public void Contact(){
            Console.WriteLine();
            Console.WriteLine("Enter Your Contact Information: ");
            Console.Write("Phone:- ");
            String phone = Console.ReadLine();
            Console.Write("Mobile:- ");
            String mobile = Console.ReadLine();
            Console.Write("Email:- ");
            String email = Console.ReadLine();
        }
        public void First_Name(){
            Console.Write("Enter your First Name: ");
            String first = Console.ReadLine();
            

        }
        public void Last_Name(){
            Console.Write("Enter your Last Name: ");
            String last = Console.ReadLine();
        }

        public void Branch_Details(){
            Console.WriteLine();
            Console.WriteLine("Enter Branch Address where you want to create your account: ");
            String branch = Console.ReadLine();
        }
    }
    interface Branch{
        void Branch_Details();
    }
    public class Current_Account : Customer{
        public void deposit(int dep, int current_balance){
            Console.WriteLine(dep + " USD deposited Successfully ..");
            current_balance = current_balance + dep;
        }
        public void withdraw(int wit, int current_balance){
            Console.WriteLine(wit + " USD withdrawn Successfully ..");
            current_balance = current_balance - wit;
        }

        public void proceed(){
            Console.WriteLine("Please, deposit minimum 500 USD within 24 hrs to make your account active.");
        }
    }

    public class SB_Account : Customer{

        public void deposit(int dep, int current_balance){
            Console.WriteLine(dep + " USD deposited Successfully ..");
            current_balance = current_balance + dep;
        }
        public void withdraw(int wit, int current_balance){
            Console.WriteLine(wit + " USD withdrawn Successfully ..");
            current_balance = current_balance - wit;
        }

        public void proceed(){
            Console.WriteLine("Please, deposit minimum 100 USD within 24 hrs to make your account active.");
        }
    }

    public class FD_Account : Customer{
        public void deposit(int dep, int current_balance){
            Console.WriteLine(dep + " USD deposited Successfully ..");
            current_balance = current_balance + dep;
        }
    }

    public class RD_Account : Customer{
  
        public void deposit(int dep, int current_balance) {
            Console.WriteLine(dep + " USD deposited Successfully ..");
            current_balance = current_balance + dep;
        }
  
    }
}
