using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Practice
{
    public class LeftCircular
    {
        public int[] LeftC(int[] arr)
        {
            int first = arr[0];
            int index = 0;
            for(int i = 1; i < arr.Length; i++)
            {
                arr[index] = arr[i];
                index++;
            }
            arr[arr.Length - 1] = first;
            return arr;
        }
    }
    public class Q32_LeftCircular
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[] { 10, 20, 30, 40, 50 };
            LeftCircular lc = new LeftCircular();
            foreach(var i in lc.LeftC(arr))
            {
                Console.WriteLine(i);
            }
        }
    }
}
