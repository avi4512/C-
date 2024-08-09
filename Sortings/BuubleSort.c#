using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading;
namespace d
{
    
    class car
    {
        public static void Bubble_sort(List<int> l)
        {
            int n = l.Count;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < (n - i - 1); j++)
                {
                    if (l[j] > l[j + 1])
                    {
                        int temp = l[j];
                        l[j] = l[j + 1];
                        l[j + 1] = temp;
                    }
                }
            }
        }
        public static void Main(string[] args)
        {
            List<int> num = new List<int> { 5, 4, 3, 2, 1 };
            
            Console.WriteLine("Before sorted List:");
            foreach (int i in num)
            {
                Console.Write(i + " ");
            }
            Bubble_sort(num);
            Console.WriteLine();
            Console.WriteLine("After sorted List:");
            foreach (int i in num)
            {
                Console.Write(i + " ");
            }
        }
    }
}



