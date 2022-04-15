using System;

namespace question_5
{
    internal class Program{
        static void Main(string[] args){
            int i, number;
            Console.Write("Enter a number :");
            number = int.Parse(Console.ReadLine());
            for (i = 1; i <= 10; i++)
            {
                Console.Write("{0} X {1} = {2} \n", number, i, number * i);

            }
            Console.ReadLine();
        }
    }
}
