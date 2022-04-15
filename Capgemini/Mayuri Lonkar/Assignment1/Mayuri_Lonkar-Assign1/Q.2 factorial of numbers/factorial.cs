using System;

class Test
{
    // method to find factorial
    // of given number
    static int factorial(int n)
    {
        if (n == 0)
            return 1;

        return n * factorial(n - 1);
    }

    // Driver method
    public static void Main()
    {
        Console.Write("Input  a number(integer): ");
        int num = Convert.ToInt32(Console.ReadLine());
        Console.Write(factorial(num));
    }
}