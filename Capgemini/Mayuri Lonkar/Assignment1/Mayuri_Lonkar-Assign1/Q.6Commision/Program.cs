using System;

namespace Commision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m1, m2, m3;
            float Tsales, Qcomm, Mincomm, Overcomm;


            Console.WriteLine("Enter the three month sales");
            m1= Convert.ToInt32(Console.ReadLine());
            m2 = Convert.ToInt32(Console.ReadLine());
            m3= Convert.ToInt32(Console.ReadLine()); 
             
            Tsales=m1+m2+m3;
            Console.WriteLine("Total sales are" + Tsales);
            if (Tsales > 15000 && Tsales < 20000)
            
                Qcomm = Tsales * 10 / 100;
            Console.WriteLine("OverallMinimun commision is", Qcomm);

            if (m1 > 5000 && m2 > 5000 && m3 > 5000)
            

                Mincomm = Tsales * 3 / 100;
                Console.WriteLine("{0}OverallMinimun commision is",  Mincomm);
            
           
            
                Overcomm = Qcomm + Mincomm;
                Console.WriteLine("Overall commision is" + Overcomm);
            Console.ReadLine();
            
       } 
    }
}
