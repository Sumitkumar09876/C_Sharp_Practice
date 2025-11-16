using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Practice
{
    public class Factorial
    {
        public int[] Fact(int num)
        {
            int[] arr = new int[num];
            int j = 0;
            for(int i = num; i >=1; i--)
            {
                arr[j] = i;
                j++;
            }
            return arr;
        }
    }

    public class Q26_Factorial
    {
        public static void Main()
        {
            Factorial ft = new Factorial();
            int product = 1;
            foreach(var i in ft.Fact(5))
            {
                Console.WriteLine(i);
                product = product * i;
            }
            Console.WriteLine($"Factorial:{product}");
        }
    }
}
