//Copy values from an array into a list using a loop.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Practice
{
    public class List3
    {
        public void CopyList(int[] arr)
        {
            List<int> list = new List<int>();
            for(int i = 0; i < arr.Length; i++)
            {
                list.Add(arr[i]);
            }
            foreach(int i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
    internal class Q16_List3Q3
    {
        public static void Main()
        {
            int[] arr = new int[] { 12, 23, 43, 25, 43, 56 };
            List3 l3 = new List3();
            l3.CopyList(arr);
        }
    }
}
