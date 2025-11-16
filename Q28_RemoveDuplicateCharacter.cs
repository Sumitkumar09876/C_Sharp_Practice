using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Practice
{
    public class RemoveDuplicateCharacter
    {
        public string RemoveDupli(string message)
        {
            HashSet<char> hs = new HashSet<char>();
            foreach(var i in message)
            {
                hs.Add(i);
            }
            string result = new string(hs.ToArray());
            return result;
        }
    }
    public class Q28_RemoveDuplicateCharacter
    {
        public static void Main()
        {
            RemoveDuplicateCharacter rdc = new RemoveDuplicateCharacter();
            Console.WriteLine(rdc.RemoveDupli("DOTNETWORLD"));
        }
    }
}
