using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Practice
{
    public class PrimeRange
    {
        public List<int> Range(int start,int end)
        {
            List<int> prime = new List<int>();
            for(int i = start; i < end; i++)
            {
                bool isPrime = true;
                for (int j = 2; j < i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                    if(isPrime && i > 1)
                    {
                        prime.Add(i);
                    }
            }
            return prime;
        }
    }
    public class Q22_PrimeRange
    {
        public static void Main()
        {
            PrimeRange pr = new PrimeRange();
            List<int> range = new List<int>(pr.Range(1, 50));
            foreach(var i in range)
            {
                Console.WriteLine(i);
            }
        }
    }
}
