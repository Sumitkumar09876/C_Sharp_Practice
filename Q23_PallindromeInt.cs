using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Practice
{
    public class PallindromeInt
    {
        public bool Pallin(int num)
        {
            int rev = 0;
            int org = num;
            while (num != 0)
            {
                int temp = num % 10;
                num = num / 10;
                rev = (rev*10) + temp;
            }
            Console.WriteLine(rev);
            if (org == rev)
            {
                return true;
            }
            return false;
        }
    }
    public class Q23_PallindromeInt
    {
        public static void Main()
        {
            PallindromeInt pt = new PallindromeInt();
            if (pt.Pallin(121))
            {
                Console.WriteLine("Pallindrome");
            }
            else
            {
                Console.WriteLine("Not a Pallindrome");
            }
        }
    }
}
