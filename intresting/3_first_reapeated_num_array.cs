using System;

namespace ConsoleApp1
{
    internal class Program
    {       
       static void Main(string[] args)
        {
            int[] arr = { 1, 2, 4, 1, 2, 8 };
            for (int i = 0; i < arr.Length; i++)
            {
                for(int j = i+1;j<arr.Length; j++)
                {
                    if(arr[i] != arr[j])
                    {
                        Console.WriteLine("First repeated number is:" + arr[i]);
                        return;
                    }
                }
            }


        }
    }
}
