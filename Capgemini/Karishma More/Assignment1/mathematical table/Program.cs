using System;

namespace mathematical_table
{
    internal class Program
    { 
        /// <summary>
        /// method for table
        /// </summary>
        /// <param name="num"></param>
         private void gettable(int num)
        { 
            //logic for table 
            for(int i=1;i<=12;i++)
            {
                int result = num * i;
                //printing table
                Console.WriteLine(i+"*"+num+"="+result);
            }
        }
        static void Main(string[] args)
        {
            //creating an object of class
            Program p = new Program();
            Console.WriteLine("enter the number");
            //calling function through a object
           p.gettable(int.Parse(Console.ReadLine()));
        }
    }
}
