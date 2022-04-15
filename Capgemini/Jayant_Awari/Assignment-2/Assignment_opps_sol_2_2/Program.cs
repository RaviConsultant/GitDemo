using System;
using Utility_opps_2_1;
namespace Assignment_opps_sol_2_2
{
    public class Account
    {
        public int currentbalance = 1000;
        public void deposit(int num)
        {
            //account.currentbalance = account.currentbalance + num;
            Console.WriteLine($"{num} USD has been deposited");
        }
        public void branch()
        {
            Branch br = new Branch();
            Console.WriteLine();
            Console.WriteLine("Enter 1 for Name");
            Console.WriteLine("Enter 2 for Address");
            Console.WriteLine("Enter 3 for Contact");

            int num = Convert.ToInt16(Console.ReadLine());
            switch (num)
            {
                case 1:
                    {
                        Console.WriteLine("Name:-" + br.Name);
                        break;
                    }
                case 2:
                    {
                        br.Address();
                        break;
                    }
                case 3:
                    {
                        br.contachinfo();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid Input");
                        break;
                    }

            }
        }
        public void cust()
        {
            try
            {
                Customer customer = new Customer();
                Console.WriteLine();
                Console.WriteLine("Enter 1 for First Name");
                Console.WriteLine("Enter 2 for Last Name");
                Console.WriteLine("Enter 3 for Address");
                Console.WriteLine("Enter 4 for contact info");
                Console.WriteLine("Enter 5 for All");
                int num = Convert.ToInt16(Console.ReadLine());

                switch (num)
                {
                    case 1:
                        {
                            customer.First_Name();
                            break;
                        }
                    case 2:
                        {
                            customer.Last_name();
                            break;
                        }
                    case 3:
                        {
                            customer.Address();
                            break;
                        }
                    case 4:
                        {
                            customer.contachinfo();
                            break;
                        }
                    case 5:
                        {
                            customer.First_Name();
                            customer.Last_name();
                            customer.Address();
                            customer.contachinfo();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid Input");
                            break;
                        }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Input");
                cust();
            }

        }
        public void account_number()
        {
            Console.WriteLine("Your acc no is:- 989397489");
        }
        public int Current_balance(int current)
        {
            return current;
        }
        public void open_account()
        {
            Console.WriteLine("Your account has been created");
        }

        public void close_account()
        {
            Console.WriteLine("Your account has been closed...");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account();
            acc.currentbalance = 1000;
            int p = 0;
            Console.WriteLine("Type 1 for Savings account:");
            Console.WriteLine("Type 2 for Current account:");
            Console.WriteLine("Type 3 for FD account:");
            Console.WriteLine("Type 4 for RD account:");
            int choose = Convert.ToInt32(Console.ReadLine());
            if (choose == 1)
            {
                while (p == 0)
                {
                    Console.WriteLine();
                    sb_account sb = new sb_account();
                    Console.WriteLine("Enter 1 for account number");
                    Console.WriteLine("Enter 2 for current balance");
                    Console.WriteLine("Enter 3 for open account");
                    Console.WriteLine("Enter 4 for deposit");
                    Console.WriteLine("Enter 5 for Withdraw");
                    Console.WriteLine("Enter 6 for close account");
                    Console.WriteLine("Enter 7 for Customer");
                    Console.WriteLine("Enter 8 for Branch");
                    Console.WriteLine("Enter 0 for exit");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 0:
                            p++;
                            break;
                        case 1:
                            acc.account_number();
                            break;
                        case 2:
                            int curren = acc.currentbalance;
                            Console.WriteLine("Your current balance is:- " + acc.Current_balance(curren));
                            break;
                        case 3:
                            acc.open_account();
                            break;
                        case 4:
                            try
                            {
                                Console.Write("How much amount you want to deposit:- ");
                                int deposit = Convert.ToInt32(Console.ReadLine());
                                acc.currentbalance = acc.currentbalance + deposit;
                                acc.deposit(deposit);
                                break;
                            }
                            catch (Exception)
                            {
                                goto default;
                            }
                        case 5:
                            try
                            {
                                Console.Write("How much amount you want to withdraw:- ");
                                int withdraw = Convert.ToInt32(Console.ReadLine());
                                sb.withdraw(withdraw, 75);
                                break;
                            }
                            catch (Exception)
                            {
                                goto default;
                            }
                        case 6:
                            acc.close_account();
                            break;
                        case 7:
                            acc.cust();
                            break;
                        case 8:
                            acc.branch();
                            break;
                        default:
                            Console.WriteLine("Invalid Input");
                            break;
                    }
                }
            }
            else if (choose == 2)
            {
                while (p == 0)
                {
                    Console.WriteLine();
                    cr_account cr = new cr_account();
                    Console.WriteLine("Enter 1 for account number");
                    Console.WriteLine("Enter 2 for current balance");
                    Console.WriteLine("Enter 3 for open account");
                    Console.WriteLine("Enter 4 for deposit");
                    Console.WriteLine("Enter 5 for Withdraw");
                    Console.WriteLine("Enter 6 for close account");
                    Console.WriteLine("Enter 7 for Customer");
                    Console.WriteLine("Enter 8 for Branch");
                    Console.WriteLine("Enter 0 for exit");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 0:
                            p++;
                            break;
                        case 1:
                            acc.account_number();
                            break;
                        case 2:
                            int curren = acc.currentbalance;
                            Console.WriteLine("Your current balance is:- " + acc.Current_balance(curren));
                            break;
                        case 3:
                            acc.open_account();
                            break;
                        case 4:
                            Console.Write("How much amount you want to deposit:- ");
                            int deposit = Convert.ToInt32(Console.ReadLine());
                            acc.currentbalance = acc.currentbalance + deposit;
                            cr.deposit(deposit);
                            break;
                        case 5:
                            Console.Write("How much amount you want to withdraw:- ");
                            int withdraw = Convert.ToInt32(Console.ReadLine());
                            cr.withdraw(withdraw, 75);
                            break;
                        case 6:
                            acc.close_account();
                            break;
                        case 7:
                            acc.cust();
                            break;
                        case 8:
                            acc.branch();
                            break;
                        default:
                            Console.WriteLine("Invalid Input");
                            break;
                    }
                }
            }
            else if (choose == 3)
            {
                while (p == 0)
                {
                    Console.WriteLine();
                    FD_account fd = new FD_account();
                    Console.WriteLine("Enter 1 for account number");
                    Console.WriteLine("Enter 2 for current balance");
                    Console.WriteLine("Enter 3 for open account");
                    Console.WriteLine("Enter 4 for deposit");
                    Console.WriteLine("Enter 5 for Branch");
                    Console.WriteLine("Enter 6 for close account");
                    Console.WriteLine("Enter 7 for Customer");
                    Console.WriteLine("Enter 0 for exit");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 0:
                            p++;
                            break;
                        case 1:
                            acc.account_number();
                            break;
                        case 2:
                            int curren = acc.currentbalance;
                            Console.WriteLine("Your current balance is:- " + acc.Current_balance(curren));
                            break;
                        case 3:
                            acc.open_account();
                            break;
                        case 4:
                            Console.Write("How much amount you want to deposit:- ");
                            int deposit = Convert.ToInt32(Console.ReadLine());
                            acc.currentbalance = acc.currentbalance + deposit;
                            fd.deposit(deposit);
                            break;
                        case 5:
                            acc.branch();
                            break;
                        case 6:
                            acc.close_account();
                            break;
                        case 7:
                            acc.cust();
                            break;
                        default:
                            Console.WriteLine("Invalid Input");
                            break;
                    }
                }
            }
            else if (choose == 4)
            {
                while (p == 0)
                {
                    Console.WriteLine();
                    RD_account rd = new RD_account();
                    Console.WriteLine("Enter 1 for account number");
                    Console.WriteLine("Enter 2 for current balance");
                    Console.WriteLine("Enter 3 for open account");
                    Console.WriteLine("Enter 4 for deposit");
                    Console.WriteLine("Enter 5 for Branch");
                    Console.WriteLine("Enter 6 for close account");
                    Console.WriteLine("Enter 7 for Customer");
                    Console.WriteLine("Enter 0 for exit");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 0:
                            p++;
                            break;
                        case 1:
                            acc.account_number();
                            break;
                        case 2:
                            int curren = acc.currentbalance;
                            Console.WriteLine("Your current balance is:- " + acc.Current_balance(curren));
                            break;
                        case 3:
                            acc.open_account();
                            break;
                        case 4:
                            Console.Write("How much amount you want to deposit:- ");
                            int deposit = Convert.ToInt32(Console.ReadLine());
                            acc.currentbalance = acc.currentbalance + deposit;
                            rd.deposit(deposit);
                            break;
                        case 5:
                            acc.branch();
                            break;
                        case 6:
                            acc.close_account();
                            break;
                        case 7:
                            acc.cust();
                            break;
                        default:
                            Console.WriteLine("Invalid Input");
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Invlid Input");

            }
        }
    }
}
