using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Practice
{
    public class CharOccurence
    {
        public void CountChar(string str)
        {
            string store = str.ToLower();
            Dictionary<char, int> ch = new Dictionary<char, int>();
            foreach (char c in store)
            {
                if (c == ' ')
                {
                    continue;
                }
                if (ch.ContainsKey(c))
                {
                    ch[c]++;
                }
                else
                {
                    ch[c] = 1;
                }
            }
            foreach (var item in ch)
            {
                Console.WriteLine($"{item.Key}:{item.Value}");
            }
        }
    }
    public class Q13_CharOccurence
    {
        public static void Main(string[] args)
        {
            string name = "My name is sumit";
            CharOccurence c = new CharOccurence();
            c.CountChar(name);
        }
    }
}

