//Exercise 4: Modify the C# code in exercise 3 in order to search for an
//element of the array using binary search algorithm.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Practice
{

    public class BinarySearch
    {
        public int[] BubbleSort(int[] num)
        {
            for(int i = 0; i < num.Length; i++)
            {
                for(int j = 0; j < num.Length - i - 1; j++)
                {
                    if (num[j] > num[j + 1])
                    {
                        int temp = num[j];
                        num[j] = num[j + 1];
                        num[j + 1] = temp;
                    }
                }
            }
            return num;
        }
        public int Search(int[] arr,int target,int n)
        {
            int left = 0;
            int right = n - 1;
            while(left<=right)
            {
                int mid = left + (right - left) / 2;
                if (arr[mid] == target)
                {
                    return mid;
                }
                else if (arr[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right=mid-1;
                }
            }
            return -1;
        }
    }
    public class Q11_BinarySearch
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[] { 23, 2, 3, 34, 6, 1, 24, 45, 78, 8 } ;
            BinarySearch bs = new BinarySearch();
            int[] store = bs.BubbleSort(arr);
            Console.WriteLine("Sorted Array:");
            for(int i = 0; i < store.Length; i++)
            {
                Console.WriteLine(store[i]);
            }
            int index = bs.Search(store, 34, 10);
            if (index == -1)
            {
                Console.WriteLine("Not Found");
            }
            else
            {
                Console.WriteLine($"Found at:{index}");
            }
            Console.ReadKey();
        }
    }
}
