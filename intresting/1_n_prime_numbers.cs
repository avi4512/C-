using System;

namespace ConsoleApp1
{
    internal class Program
    {
        public static bool prime(int n)
        {
            bool isprime = true;
            if (n < 1)
            {
                isprime = false;
                return isprime;
            }
            else if (n > 1)
            {
                for(int i=2;i<n;i++)
                {
                    if(n % i == 0)
                    {
                        isprime = false;
                        break;
                        return isprime;
                    }
                   
                }
            }
            return isprime;
           

        }
        static void Main(string[] args)
        {
            int n = 10;
            for (int i = 2; i < n; i++)
            {
                if(prime(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
