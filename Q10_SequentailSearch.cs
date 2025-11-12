//Exercise 3: By using the sequential search algorithm, write C# code to search
//for an element of an integer array of 10 elements.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Practice
{
    public class SequentailSearch
    {
        public SequentailSearch(int[] arr,int target,int n)
        {
            for(int i = 0; i < n; i++)
            {
                if (target == arr[i])
                {
                    Console.WriteLine($"Found at Index:{i}");
                    break;
                }
            }
        }
    }
    public class Q10_SequentailSearch
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[10] { 23, 2, 3, 34, 6, 1, 24, 45, 78, 8 };
            Console.WriteLine("Enter the Number:");
            int target = Convert.ToInt32(Console.ReadLine());
            SequentailSearch ss = new SequentailSearch(arr,target,10);
        }
    }
}
