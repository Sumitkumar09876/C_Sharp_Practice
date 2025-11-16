//1.Word Frequency Counter
//Write a method that takes a long string of text and returns a Dictionary<string, int> where the key is a word and
//the value is the number of times that word appeared.

//Extra Challenge: Make it case-insensitive (e.g., "The" and "the" should count as the same word).

//Hint: You'll need to use string.Split() and check if the key already exists before adding or updating.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Practice
{
    public class FrequencyCounter
    {
        public void FreqCount(string temp)
        {
            string name = temp.ToLower(); 
            Dictionary<char,int> dict1 = new Dictionary<char,int>();
            foreach(var i in name)
            {
                if (i==' ')
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
                Console.WriteLine($"{i.Key}:{i.Value}");
            }
        }
    }
    public class Q18_FrequencyCounter
    {
        public static void Main()
        {
            string name = "I am the king of this world";
            FrequencyCounter fc = new FrequencyCounter();
            fc.FreqCount(name);
        }
    }
}
