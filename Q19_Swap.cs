using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Practice
{
    public class Q19_Swap
    {
        public static void Main(string[] args)
        {
            int num1 = 10,num2=20;
            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;
            Console.WriteLine($"num1:{num1} num2:{num2}");
        }
    }
}
