//Create a list of 5 integers and print only even numbers.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Practice
{
    public class List1
    {
        public void EvenList()
        {
            List<int> list = new List<int>();
            for(int i = 0; i < 5; i++)
            {
                list.Add(i);
            }
            foreach(int item in list)
            {
                if (item % 2 == 0)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
    public class Q14_List1Q1
    {
        public static void Main()
        {
            List1 l1 = new List1();
            l1.EvenList();
        }
    }
}
