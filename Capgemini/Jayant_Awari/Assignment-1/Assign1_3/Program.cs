
using System;

class program
{

	//function to check if a given number is prime
	static bool isPrime(int n)
	{
		//since 0 and 1 is not prime return false.
		if (n == 1 || n == 0) return false;

		for (int i = 2; i <= n / 2; i++)
		{
			
			if (n % i == 0) return false;
		}
		
		return true;
	}

	
	public static void Main(String[] args)
	{
		
	
		for (int i = 1; i <= N; i++)
		{
			//check if current number is prime
			if (isPrime(i))
			{
				Console.Write(i + " ");
			}
		}

	}
}

