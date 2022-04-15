using System;

namespace IBank.Design2{
    //interfaces 'Account' and 'IAccount' are used for Multiple Inheritance
    interface Account{
        void Account_Number();
        void Address();
        void Contact();
        void First_Name();
        void Last_Name();
        void Branch_Details();
    }

    interface IAccount{
        void OpenAccount();
        void CloseAccount();
        void deposit(int dep, int current_balance);
        void withdraw(int wit, int current_balance);
    }

    //Class current Account inherits from Account and IAccount
    public class Current_Account : Account, IAccount{
        public void Account_Number(){
            Console.WriteLine(" Your Account no. is : 2002365445");
        }
        public void OpenAccount(){
            Console.WriteLine("Account Opened Successfully !!");
        }

        public void CloseAccount(){
            Console.WriteLine("Account Closed ....");
        }

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
        public void deposit(int dep, int current_balance){
            Console.WriteLine(dep + " USD deposited Successfully ..");
            current_balance = current_balance + dep;
        }
        public void withdraw(int wit, int current_balance){
            Console.WriteLine(wit + " USD withdrawn Successfully ..");
            current_balance = current_balance - wit;
        }

        public void proceed_cr() {
            Console.WriteLine("Please, deposit minimum 500 USD within 24 hrs to make your account active.");
        }
    }
        // Here multilevel inheritance is used, SB_Account inherits from Current_Account
        public class SB_Account : Current_Account{
            public void proceed_sb(){
                Console.WriteLine("Please, deposit minimum 100 USD within 24 hrs to make your account active.");
            }
        }
        // FD_Account inherits form SB_Account
        public class FD_Account : SB_Account{

        }
        // RD_Account inherits from FD_Account
        public class RD_Account : FD_Account{

        }

        // Multilevel Inheritance was used because, all account types share same properties
    internal class Program{
        static void Main(string[] args){
            Console.WriteLine("Type 1 to create a Savings account:");
            Console.WriteLine("Type 2 to create a Current account:");
            Console.WriteLine("Type 3 to create a FD account:");
            Console.WriteLine("Type 4 to create a RD account:");

            int choose = int.Parse(Console.ReadLine());

            //object of last class i.e., RD_Account is created which will automatically access properties of intermediary class,
            //base class and interfaces
            RD_Account rd = new RD_Account();

            if (choose == 1){

                rd.First_Name();
                rd.Last_Name();
                rd.Contact();
                rd.Address();
                rd.Branch_Details();
                rd.OpenAccount();
                rd.Account_Number();

                int current_balance = 0;
                Console.WriteLine("Your Current Balance is: " + current_balance + " USD");

                rd.proceed_cr();

                int var = 0;

                while (var == 0 || var == 1){
                    Console.WriteLine("Press 0 to Withdraw Money");
                    Console.WriteLine("Press 1 to Deposit Money");
                    Console.WriteLine("Press any num key other than 0 or 1 to Exit");

                    int command = int.Parse(Console.ReadLine());
                    var = command;

                    if (command == 0){
                    Again:
                        Console.WriteLine("Enter Amount to be Deposited in USD: ");
                        int dep = int.Parse(Console.ReadLine());

                        if (dep < 500){
                            Console.WriteLine("Amount Should be minimum 500 USD");
                            goto Again;
                        }
                        else
                            rd.deposit(dep, current_balance);
                    }

                    if (command == 1){
                    Again:
                        Console.WriteLine("Enter Amount to be Withdrawn in USD: ");
                        int wit = int.Parse(Console.ReadLine());

                        if (wit > 400 || ((current_balance - wit) < 500)){
                            Console.WriteLine("Current Balance should be maintained 500 USD and Maximum withdrawl amount is 400/trans");
                            goto Again;
                        }
                        else
                            rd.withdraw(wit, current_balance);
                    }

                    else if (command != 0 && command != 1){
                        rd.CloseAccount();
                    }
                }
            }

            if (choose == 2){

                rd.First_Name();
                rd.Last_Name();
                rd.Contact();
                rd.Address();
                rd.Branch_Details();
                rd.OpenAccount();
                rd.Account_Number();

                int current_balance = 0;
                Console.WriteLine("Your Current Balance is: " + current_balance + " USD");

                rd.proceed_sb();

                int var = 0;

                while (var == 0 || var == 1){
                    Console.WriteLine("Press 0 to Withdraw Money");
                    Console.WriteLine("Press 1 to Deposit Money");
                    Console.WriteLine("Press any num key other than 0 or 1 to Exit");

                    int command = int.Parse(Console.ReadLine());
                    var = command;

                    if (command == 0){
                    Again:
                        Console.WriteLine("Enter Amount to be Deposited in USD: ");
                        int dep = int.Parse(Console.ReadLine());

                        if (dep < 500){
                            Console.WriteLine("Amount Should be minimum 500 USD");
                            goto Again;
                        }
                        else
                            rd.deposit(dep, current_balance);
                    }

                    if (command == 1){
                    Again:
                        Console.WriteLine("Enter Amount to be Withdrawn in USD: ");
                        int wit = int.Parse(Console.ReadLine());

                        if (wit > 400 || ((current_balance - wit) < 500)){
                            Console.WriteLine("Current Balance should be maintained 500 USD and Maximum withdrawl amount is 400/trans");
                            goto Again;
                        }
                        else
                            rd.withdraw(wit, current_balance);
                    }

                    else if (command != 0 && command != 1){
                        rd.CloseAccount();
                    }
                }
            }

            if (choose == 3){

                rd.First_Name();
                rd.Last_Name();
                rd.Contact();
                rd.Address();
                rd.Branch_Details();
                rd.OpenAccount();
                rd.Account_Number();

                int current_balance = 0;
                Console.WriteLine("Your Current Balance is: " + current_balance + " USD");

                rd.proceed_cr();

                int var = 1;

                while (var == 1){
                    Console.WriteLine("Press 1 to Deposit Money");
                    Console.WriteLine("Press any num key other than 1 to Exit");

                    int command = int.Parse(Console.ReadLine());
                    var = command;

                    if (command == 1){
                    Again:
                        Console.WriteLine("Enter Amount to be Deposited in USD: ");
                        int dep = int.Parse(Console.ReadLine());

                        if (dep < 500){
                            Console.WriteLine("Amount Should be minimum 500 USD");
                            goto Again;
                        }
                        else
                            rd.deposit(dep, current_balance);
                    }

                    else if (command != 1){
                        rd.CloseAccount();
                    }
                }
            }

            if (choose == 4){

                rd.First_Name();
                rd.Last_Name();
                rd.Contact();
                rd.Address();
                rd.Branch_Details();
                rd.OpenAccount();
                rd.Account_Number();

                int current_balance = 0;
                Console.WriteLine("Your Current Balance is: " + current_balance + " USD");

                rd.proceed_cr();

                int var = 1;

                while (var == 1){
                    Console.WriteLine("Press 1 to Deposit Money");
                    Console.WriteLine("Press any num key other than 1 to Exit");

                    int command = int.Parse(Console.ReadLine());
                    var = command;

                    if (command == 1){
                    Again:
                        Console.WriteLine("Enter Amount to be Deposited in USD: ");
                        int dep = int.Parse(Console.ReadLine());

                        if (dep < 500){
                            Console.WriteLine("Amount Should be minimum 500 USD");
                            goto Again;
                        }
                        else
                            rd.deposit(dep, current_balance);
                    }

                    else if (command != 1){
                        rd.CloseAccount();
                    }
                }
            }
        }
    }
}
