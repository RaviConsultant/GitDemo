using System;
using IBank.Utility;

namespace IBank.Design1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type 1 to create a Savings account:");
            Console.WriteLine("Type 2 to create a Current account:");
            Console.WriteLine("Type 3 to create a FD account:");
            Console.WriteLine("Type 4 to create a RD account:");

            int choose = int.Parse(Console.ReadLine());

            Account ac = new Account();

            if (choose == 1)
            {
                SB_Account sb = new SB_Account();

                sb.First_Name();
                sb.Last_Name();
                sb.Contact();
                sb.Address();
                sb.Branch_Details();

                ac.OpenAccount();
                ac.Account_Number();

                int current_balance = 0;
                Console.WriteLine("Your Current Balance is: " + current_balance + " USD");

                sb.proceed();

                int var = 0;

                while (var == 0 || var == 1)
                {
                    Console.WriteLine("Press 0 to Withdraw Money");
                    Console.WriteLine("Press 1 to Deposit Money");
                    Console.WriteLine("Press any num key other than 0 or 1 to Exit");

                    int command = int.Parse(Console.ReadLine());
                    var = command;

                    if (command == 1)
                    {
                        Again:
                        Console.WriteLine("Enter Amount to be Deposited in USD: ");
                        int dep = int.Parse(Console.ReadLine());

                        if (dep < 500)
                        {
                            Console.WriteLine("Amount Should be minimum 500 USD");
                            goto Again;
                        }
                        else
                            sb.deposit(dep, current_balance);
                    }

                    if (command == 0)
                    {
                        Again:
                        Console.WriteLine("Enter Amount to be Withdrawn in USD: ");
                        int wit = int.Parse(Console.ReadLine());

                        if (wit > 400 || ((current_balance - wit) < 500))
                        {
                            Console.WriteLine("Current Balance should be maintained 500 USD and Maximum withdrawl amount is 400/trans");
                            goto Again;
                        }
                        else
                            sb.withdraw(wit, current_balance);
                    }

                    else if (command != 0 && command != 1)
                    {
                        ac.CloseAccount();
                    }
                }
                

            }

            if (choose == 2)
            {
                Current_Account cr = new Current_Account();

                cr.First_Name();
                cr.Last_Name();
                cr.Contact();
                cr.Address();
                cr.Branch_Details();

                ac.OpenAccount();
                ac.Account_Number();

                int current_balance = 0;
                Console.WriteLine("Your Current Balance is: " + current_balance + " USD");

                cr.proceed();

                int var = 0;

                while (var == 0 || var == 1)
                {
                    Console.WriteLine("Press 0 to Withdraw Money");
                    Console.WriteLine("Press 1 to Deposit Money");
                    Console.WriteLine("Press any num key other than 0 or 1 to Exit");

                    int command = int.Parse(Console.ReadLine());
                    var = command;

                    if (command == 1)
                    {
                    Again:
                        Console.WriteLine("Enter Amount to be Deposited in USD: ");
                        int dep = int.Parse(Console.ReadLine());

                        if (dep < 100)
                        {
                            Console.WriteLine("Amount Should be minimum 100 USD");
                            goto Again;
                        }
                        else
                            cr.deposit(dep, current_balance);
                    }

                    if (command == 0)
                    {
                    Again:
                        Console.WriteLine("Enter Amount to be Withdrawn in USD: ");
                        int wit = int.Parse(Console.ReadLine());

                        if (wit > 75 || ((current_balance - wit) < 100))
                        {
                            Console.WriteLine("Current Balance should be maintained 100 USD and Maximum withdrawl amount is 75/trans");
                            goto Again;
                        }
                        else
                            cr.withdraw(wit, current_balance);
                    }

                    else if (command != 0 && command != 1)
                    {
                        ac.CloseAccount();
                    }
                }
            }

            if (choose == 3)
            {
                FD_Account fd = new FD_Account();

                fd.First_Name();
                fd.Last_Name();
                fd.Contact();
                fd.Address();
                fd.Branch_Details();

                ac.OpenAccount();
                ac.Account_Number();

                int current_balance = 0;
                Console.WriteLine("Your Current Balance is: " + current_balance + " USD");

                int var = 1;

                while (var == 1)
                {
                    Console.WriteLine("Press 1 to Deposit Money");
                    Console.WriteLine("Press any num key other than 1 to Exit");

                    int command = int.Parse(Console.ReadLine());
                    var = command;

                    if (command == 1)
                    {
                    Again:
                        Console.WriteLine("Enter Amount to be Deposited in USD: ");
                        int dep = int.Parse(Console.ReadLine());

                        if (dep < 100)
                        {
                            Console.WriteLine("Amount Should be minimum 100 USD");
                            goto Again;
                        }
                        else
                            fd.deposit(dep, current_balance);
                    }

                    else if (command != 1)
                    {
                        ac.CloseAccount();
                    }
                }
            }

            if (choose == 4)
            {
                RD_Account rd = new RD_Account();

                rd.First_Name();
                rd.Last_Name();
                rd.Contact();
                rd.Address();
                rd.Branch_Details();

                ac.OpenAccount();
                ac.Account_Number();

                int current_balance = 0;
                Console.WriteLine("Your Current Balance is: " + current_balance + " USD");

                int var = 1;

                while (var == 1)
                {
                    Console.WriteLine("Press 1 to Deposit Money");
                    Console.WriteLine("Press any num key other than 1 to Exit");

                    int command = int.Parse(Console.ReadLine());
                    var = command;

                    if (command == 1)
                    {
                    Again:
                        Console.WriteLine("Enter Amount to be Deposited in USD: ");
                        int dep = int.Parse(Console.ReadLine());

                        if (dep < 100)
                        {
                            Console.WriteLine("Amount Should be minimum 100 USD");
                            goto Again;
                        }
                        else
                            rd.deposit(dep, current_balance);
                    }

                    else if (command != 1)
                    {
                        ac.CloseAccount();
                    }
                }
            }
        }

    }
}
