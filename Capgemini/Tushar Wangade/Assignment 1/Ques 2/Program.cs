using System;

class Test
{
    // method to find factorial
    // of given number
    int factorial(int n)
    {
        if (n == 0)
            return 1;

        return n * factorial(n - 1);
    }

    // main method
    public static void Main()
    {

    Again:
        //try catch block until suitable input is provided
        try
        {
            Console.Write("Input  a number(integer): ");
            int num = Convert.ToInt32(Console.ReadLine());
            Test p = new Test();
            //output
            Console.Write(p.factorial(num));
        }
        catch
        {
            goto Again;
        }
    }
}