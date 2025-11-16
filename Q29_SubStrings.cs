using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Practice
{
    public class SubStrings
    {
        public void SubStr(string message)
        {
            string substr=string.Empty;
            for(int i = 0; i < message.Length; i++)
            {
                for(int j = i; j < message.Length; j++)
                {
                    substr= substr + message[j];
                    Console.WriteLine(substr);
                }
                substr = string.Empty;
            }
        }
    }
    public class Q29_SubStrings
    {
        public static void Main()
        {
            SubStrings ss = new SubStrings();
            ss.SubStr("ABC");
        }
    }
}
