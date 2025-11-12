using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Practice
{
    public class SumOfNumber
    {
        public int SumOfNumbers(int num)
        {
            int store = 0, sum = 0;
            while (num != 0)
            {
                store = num % 10;
                num = num / 10;
                sum += store;
            }
            return sum;

        }
    }
    public class Q7_SumOfNumbers
    {

        public static void Main(string[] args)
        {
            SumOfNumber son = new SumOfNumber();
            Console.WriteLine($"Sum of digits:{son.SumOfNumbers(3567)}");
        }

    }
}
