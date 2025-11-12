//Exercise 1 : By using the bubble sort algorithm, write C# code to sort
//an integer array of 10 elements in ascending & Descending order
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Practice
{
    public class BubbleSort
    {
        public void BubbleSortAsc(int[] num)
        {
            int n = num.Length;
            for(int i = 0;i< n; i++)
            {
                for(int j = 0; j < n - i - 1; j++)
                {
                    if (num[j] > num[j + 1])
                    {
                        int temp = num[j];
                        num[j] = num[j + 1];
                        num[j + 1] = temp;
                    }
                }
            }
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine(num[i]);
            }
        }
        //Descending Order
        public void BubbleSortDsc(int[] num)
        {
            int n = num.Length;
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n - i - 1; j++)
                {
                    if (num[j] < num[j + 1])
                    {
                        int temp = num[j];
                        num[j] = num[j + 1];
                        num[j + 1] = temp;
                    }
                }
            }
                Console.WriteLine(string.Join(" ",num));
        }
    }
    public class Q9_BubbleSort
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter 10 Elements:"); 
            int[] arr = new int[10] { 23, 2, 3, 34, 6, 1, 24, 45, 78, 8 };
            BubbleSort bs = new BubbleSort();
            bs.BubbleSortAsc(arr);
            Console.WriteLine("Descending Order:");
            bs.BubbleSortDsc(arr);
        }
    }
}
