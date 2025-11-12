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
            Dictionary<char, int> charCount = new Dictionary<char, int>();
            
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                {
                    if (charCount.ContainsKey(str[i]))
                    {
                        charCount[str[i]]++;
                    }
                    else
                    {
                        charCount[str[i]] = 1;
                    }
                }
            }
            List<KeyValuePair<char, int>> items = charCount.ToList();
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine($"{items[i].Key}:{items[i].Value}");
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
