using LibraryFunctions.Functions;
using System;
using LibraryFunction.Calculate;

namespace MohitPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //
            Functions impLI = new Functions();// creating impLI object to implement class methods
            Calculate call = new Calculate();//creating call object to implement class methods
            try
            {                                             //Problem 1 code 

                //do // creating  an infinite loop by do while which accepts a integer variable than break
                //{
                //    Console.WriteLine("Please enter a number(only a positive whole number):");
                //    string input = (Console.ReadLine());// reading input from command line and storing it in a string
                //    int number;
                //    if (int.TryParse(input, out number) && number > 0)// TryParse can work here as check for an integer value
                //    {
                //        Console.WriteLine("The sum of digits of {0} is {1}", input, impLI.sumofdigit(input));// calling sumofdigit function from library class
                //        break;
                //    }
                //    else continue;
                //} while (true);

                //Problem 2 code (implementation) 

                //Console.WriteLine(impLI.fact(5));// passing value in fac() function of library class through class object impLI

                //Problem 3 code (implemetation) 

                // impLI.printprimetill(10);//passing value in printprimetill() funtion of libraray class throught object implI

                //Problem 4 code (implementation)

                //Console.WriteLine(impLI.IsPallidrome("NAMAN"));//passing value in IsPallidrome() funtion of libraray class throught object implI

                //Problem 5 code (implementation)

                // impLI.tabletill12(7);////passing value in tabletill12() funtion of libraray class throught object implI

                //Problem 6 code (implementation)


                int[] month = new int[3];
                int sum = 0;
                for (int i = 0; i < month.Length; i++)
                {
                    Console.WriteLine("Month - {0} Sales in USD:", i + 1);
                    month[i] = Convert.ToInt32(Console.ReadLine());//reading values from command line
                    sum += month[i];
                }

                Console.WriteLine("Total Sale for the Quarter: {0}", sum);// printing value of sum
                Console.WriteLine("Quarterly_Commission: {0}", call.Quaterly_Com(sum));//accessing Library class by object call & it will return Quaterly Commission
                Console.WriteLine("Minimum_Commission: {0}", call.Monthly_Com(month));//accessing Library class by object call & it will return Monthly Commission
                Console.WriteLine("Overall Commission for the Quarter: {0}", call.Monthly_Com(month) + call.Quaterly_Com(sum));//accessing Library class by object call & it will return sumof Quaterly Commission+ monthly commision

            }
            catch (Exception ex)// catch block to catch any exception if any at run time
            {
                Console.WriteLine("Your code have been commited some Runtime-errors here:\n{0}", ex.Message);// giving user an error message 
            }
            finally { Console.ReadLine(); }// finally block to hold the screen either succesful or unsuccessfull implementation of code

        }





    }

}
