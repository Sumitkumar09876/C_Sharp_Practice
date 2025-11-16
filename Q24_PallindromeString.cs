using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Practice
{
    public class PallindromeString
    {
        string rev;
        public bool Pallin(string name)
        {
            foreach(char c in name)
            {
                rev = c + rev;
            }
            if (rev == name)
            {
                return true;
            }
            return false;
        }
    }
    public class Q24_PallindromeString
    {
        public static void Main()
        {
            PallindromeString ps = new PallindromeString();
            if (ps.Pallin("MADAM"))
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
