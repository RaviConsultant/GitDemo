using System;
   /// Program to find all the prime number under given number.
   /// </summary>
namespace Question_3
{
    internal class Question_3
    {
        static void Main(string[] args)
        {
            int primeNum = 0;    ///Input number
            int counter=1;
            int temp,i;
            bool validation = true;

            // validation of the input
            while (validation)
            {
                string Input;
                Console.WriteLine("Enter the number whose prime numbers you want to find");
                Input = Console.ReadLine();
                var isvalid=int.TryParse(Input, out primeNum);
               
            }

            
            
            Console.WriteLine("The prime numbers under {0} are", primeNum); ////will give the output prime numbers
            while(counter < primeNum)
            {
                counter++;
                temp = 0;
                for(i=2;i<=(counter/2);i++)  ////logic to get the prime numbers

                {
                    if(counter%i==0)
                    {
                        temp = 1;
                        break;
                    }
                }
                if(temp==0)
                {
                    Console.Write("{0} , ",counter);
                    
                }
            }
        
        }
    }
}
