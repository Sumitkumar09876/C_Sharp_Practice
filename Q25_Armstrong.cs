using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Practice
{
    public class Armstrong
    {
        public bool Arm(int num)
        {
            int length = num.ToString().Length;
            int product = 1,sum=0;
            int org = num;
            while (num != 0)
            {
                int temp = num % 10;
                num = num / 10;
                for(int i = 0; i < length; i++)
                {
                    product = product * temp;
                }
                sum = sum + product;
                product = 1;
            }
            if (sum == org)
            {
                return true;
            }
            return false;
        }
    }
    public class Q25_Armstrong
    {
        public static void Main()
        {
            Armstrong armstrong = new Armstrong();
            if (armstrong.Arm(371)){
                Console.WriteLine("Armstrong Number");
            }
            else
            {
                Console.WriteLine("Not a Armstrong");
            }
        }
    }
}
