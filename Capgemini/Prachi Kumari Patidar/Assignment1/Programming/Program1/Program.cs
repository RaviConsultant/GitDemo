using System;


namespace Program1
{
    internal class Program
    {
        // Sum of Number Function
        public static int sum1(string n)
        {
            int sum = 0;
            int n1 = Convert.ToInt32(n);
            while (n1 != 0)
            {
                sum = sum + n1 % 10;
                n1 = n1 / 10;
            }

            return sum;
        }

        // Factorial of the number Function
        public static int Factorial(int num)
        {
            if (num == 1)
            {
                return 1;
            }
            else
            {
                return num * Factorial(num - 1);
            }
        }

        //IsPrime Function
        public static bool isPrime(int num)
        {
            for(int i = 2; i <= num/2; i++)
            {
                if(num % i == 0)
                {
                    return false;
                }
                
            }
            return true;
        }

        //Palindrome String Function
        public static bool isPal(string s)
        {
            string rev = String.Empty;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                rev = rev + s[i];
            }
            if (rev.Equals(s))
                return true;
            else return false;
        }

        // Table Function
        public static int Monthly_Com(int[] m)
        {
            int sum = 0;
            for (int i = 0; i < m.Length; i++)
            {
                if (m[i] >= 5000) 
                    sum += (m[i] / 100) * 3;
                else sum += 0;
            }
            return sum;

        }

        public static int Quaterly_Com(int s)
        {
            int r = s / 100;
            if (s >= 20000) return r * 12;
            else if (s >= 15000 && s < 20000) return r * 10;
            else if (s >= 10000 && s < 15000) return r * 5;
            else return 0;
        }

        static void Main(string[] args)

        {

            //Program1 (sum of digits of the number)
            //do
            //{
            //    Console.WriteLine("Please enter a number(only a positive whole number): ");
            //    string rs = (Console.ReadLine());
            //    int n;
            //    if (int.TryParse(rs,out n))
            //    {
            //        Console.WriteLine(sum1(rs));
            //        break;
            //    }
            //    else continue;
            //} while (true);





            // program2(Factorial of Number)
            //String str = Console.ReadLine();
            //int num = int.Parse(str);
            //Console.WriteLine(Factorial(num));



            // Program3(Print First N Prime Number
            //String str = Console.ReadLine();
            //int num = int.Parse(str);
            //for(int i = 2; i < num; i++)
            //{
            //    if (isPrime(i))
            //    {
            //        Console.WriteLine(i);

            //    }

            //}


            //program 4
            //String str = Console.ReadLine();
            //Console.WriteLine(isPal(str));



            // Program 5
            // String str = Console.ReadLine();
            //int num = int.Parse(str);
            //for(int i = 1; i <= 12; i++)
            //{
            //    Console.WriteLine(i +"*"+ num + "=" + (i*num));
            //}



            //Program 6
            int[] month = new int[3];
            int sum = 0;
            for (int i = 0; i < month.Length; i++)
            {
                Console.WriteLine($"Month-{0} Sales in USD:", i );
                month[i] = Convert.ToInt32(Console.ReadLine());
                sum += month[i];
            }
            Console.WriteLine("Total Sale for the Quarter : {0} USD", sum);
            Console.WriteLine("quarterly_Commission: {0} USD", Quaterly_Com(sum));
            Console.WriteLine("Minimum_Commission: {0}USD", Monthly_Com(month));
            Console.WriteLine("Overall Commission for the Quarter: {0} USD", Monthly_Com(month) + Quaterly_Com(sum));

        }



    }

}


