//Create a dictionary of 5 students (roll → name) and print all names.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Practice
{
    public class Dict1
    {
        public void loop(string[] name)
        {
            Dictionary<int, string> dict1 = new Dictionary<int, string>();
            for(int i=0;i<name.Length;i++)
            {
                dict1.Add(i,name[i]);
            }
            foreach(var i in dict1)
            {
                Console.WriteLine($"Roll No:{i.Key} & Name:{i.Value}");
            }

        }
    }
    public class Q17_Dict1Q1
    {
        public static void Main(string[] args)
        {
            string[] name = new string[] {"Sumit","kumar","Rahul","Shaym","Kamlesh"};
            Dict1 d1 = new Dict1();
            d1.loop(name);
        }
    }
}
