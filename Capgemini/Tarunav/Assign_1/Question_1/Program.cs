using System;

namespace question_1
       {
    internal class Program{
        // Function to get sum of numbers
        // Sum number will also be a uint. So return type is uint. 
        uint getSum(uint number){
            // perform sum of digits after each iteration 
            uint sum = 0; 
            while (number != 0){
                sum = sum + number % 10;
                number = number / 10;
            }
            return sum;
        }
        static void Main(string[] args){
            // the Try - Catch Block will execute until suitable input is provided 
            Again:
            try{
                // user input
                Console.Write("Please enter a number(only a positive whole number): ");
                // value of 'uint' datatype is used because only positive whole number is the desired input 
                uint number = uint.Parse(Console.ReadLine());

                Program A = new Program();

                // output
                Console.WriteLine("The sum of digits  " + number + " is " + A.getSum(number));
            }
            catch{
                goto Again;
            }
        }
    }
}
