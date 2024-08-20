using System;

namespace ConsoleApp1
{
    internal class Program
    {
        public static bool prime(int n)
        {
            bool isprime = true;
            if (n <= 1)
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
            int[] arr = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            int n = arr.Length;
            int result = 0;
            for (int i = 0; i < n; i++)
            {
                if(prime(i) == false)
                {
                    result = result + arr[i];
                }
            }
            Console.WriteLine(result);

        }
    }
}
