//Fibonacci Series
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Practice
{
    internal class Q6_Fibonacci_Series
    {
        public void Fib(int num)
        {
            int a = 0;
            int b = 1;
            if (num <= 0)
            {
                Console.WriteLine("Enter a valid number");
            }
            else
            {
                for(int i = 0; i < num; i++)
                {
                    Console.WriteLine(a+" ");
                    int c = a + b;
                    a = b;
                    b = c;
                }
            }
        }
        public static void Main()
        {
            Q6_Fibonacci_Series fb = new Q6_Fibonacci_Series();
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            fb.Fib(num);
        }
    }
}
