using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Practice
{
    public class CharacterOccurence
    {
        public void CharOcc(string name)
        {
            string low = name.ToLower();
            Dictionary<char, int> dict1 = new Dictionary<char, int>();
            foreach(var i in low)
            {
                if(i==' ')
                {
                    continue;
                }
                if (dict1.ContainsKey(i))
                {
                    dict1[i]++;
                }
                else
                {
                    dict1[i] = 1;
                }

            }
            foreach(var i in dict1)
            {
                Console.WriteLine($"Character:{i.Key} Occurence:{i.Value}");
            }
        }
    }
    public class Q27_CharacterOccurence
    {
        public static void Main()
        {
            CharacterOccurence co = new CharacterOccurence();
            co.CharOcc("I am the king of this world");
        }
    }
}
