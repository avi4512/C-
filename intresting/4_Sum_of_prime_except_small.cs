using System;

namespace ConsoleApp1
{
    internal class Program
    {
        public static bool isprime(int n)
        {
            bool prime = true;
            if(n <= 1)
            {
                prime = false;
            }
            for(int i = 2;i < n; i++)
            {
                if (n % i == 0)
                {
                    prime = false;
                    break;
                }
            }
            return prime;
        }
            
           
            
       static void Main(string[] args)
        {

            int[] arr = { 2, 3, 4, 5, 6, 7, 8, 9 };
            List<int> list = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if(isprime(arr[i]))
                {
                    list.Add(arr[i]);
                }
            }
            list.Sort();
            int res = 0;
            for (int i = 1; i < list.Count; i++)
            {
               res = res + list[i];
            }
            Console.WriteLine(res);
           
        }
    }
}
