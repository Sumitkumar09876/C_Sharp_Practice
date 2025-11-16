using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Practice
{
    public class PrimeNumber
    {
        public bool prime(int num)
        {
            for(int i = 2; i < num/2; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
    public class Q21_PrimeNumber
    {
        public static void Main()
        {
            PrimeNumber pn = new PrimeNumber();
            if (pn.prime(4))
            {
                Console.WriteLine($"Prime Number");
            }
            else
            {
                Console.WriteLine("Not a Prime");
            }
        }
    }
}
