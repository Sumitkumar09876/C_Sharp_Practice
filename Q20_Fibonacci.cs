using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Practice
{
    public class FibonacciSeries
    {
        public void fib(int num)
        {
            int a = 0;
            int b = 1;
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine(a);
                int c = a + b;
                a = b;
                b = c;
            }
        }
    }
    public class Q20_Fibonacci
    {
        public static void Main()
        {
            FibonacciSeries fb = new FibonacciSeries();
            fb.fib(12);
        }
    }
}
