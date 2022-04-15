using System;

namespace question_2
{
    internal class Program{
        // Function to calculate factorial
        // Factorial of a uint number will also be a uint. So, return type is also uint 
        uint factorial(uint number){
            uint i;                                             
            uint facto = 1;
            for(i = 1; i <= number; i++){
                facto = facto * i;
            }
            return facto;
        }
        static void Main(string[] args){
            // In case, if user gives input other than 'uint', then this goto statement will reiterate 
            // the Try - Catch Block untill suitable input is provided 
            Again:
            try{
                // user input
                Console.Write("Enter a whole Number(only a positive whole number): ");
                // value of 'uint' datatype is used because only positive whole number is the desired input 
                uint number = uint.Parse(Console.ReadLine());

                Program p = new Program();

                // Output Statement
                // if the input Number is 0, then its factorial will also be 0
                if (number == 0){
                    Console.WriteLine("The factorial of  " + number + " is 1");
                }
                else{
                    Console.WriteLine("The factorial of  " + number + " is " + p.factorial(number));
                }
            }
            catch{
                goto Again;
            }
        }
    }
}
