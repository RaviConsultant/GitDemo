using System;

namespace PrimeNumber
{
	internal class Program
	{
		static void Main(string[] args)
		{
			
			int number;

			int i, p, k;
			
			Console.Write("Enter a number:");
			string input = Console.ReadLine();

		
			 //validating user input
			if(int.TryParse(input, out number) && number < 0)
            {
				Console.WriteLine("Enter positive whole number");
					
            }
			
			else if ((int.TryParse(input, out number) || number > 0))
			{
				//finding factorial of numbers
				for (i = 2; i <= number; i++)
				{
					k = 2;
					p = 1;
					while (k < i)
					{
						if (i % k == 0)
						{
							p = 0;
							break;
						}
						k++;
					}
					if (p == 1)
					{
						Console.Write (i+",");

					}
				}
				

			}
			else
            {
				Console.WriteLine("Enter positive whole number");
					
				}
	 	

		}
	}
}

