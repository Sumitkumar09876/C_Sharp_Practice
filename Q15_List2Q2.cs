//Add 10 numbers to a list using a loop and print the sum.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Practice
{
    public class List2
    {
        public void Loop1()
        {
            List<int> list = new List<int>();
            Console.WriteLine("Enter the Number:");
            for(int i = 0; i < 10; i++)
            {
                int store = Convert.ToInt32(Console.ReadLine());
                list.Add(store);
                
            }
            int sum = 0;
            foreach(int i in list)
            {
                 sum = sum + i; 
            }
            Console.WriteLine(sum);
        }
    }
    public class Q15_List2Q2
    {
        public static void Main()
        {
            List2 l2 = new List2();
            l2.Loop1();
        }
    }
}
