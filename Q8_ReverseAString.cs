using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Practice
{
    public class ReverseAString
    {
     public void Reverse(string Name)
        {
            int size = Name.Length - 1;
            char[] store = new char[size + 1];
            int j = 0;
            for (int i = size; i >=0; i--)
            {
                store[j] = Name[i];
                j++;
            }
            Console.WriteLine($"Rever:{new string(store)}");
        }
    }
    public class Q8_ReverseAString
    {
     public static void Main(string[] args)
        {
            Console.WriteLine("Enter the name:");
            string name = Console.ReadLine();
            ReverseAString ras = new ReverseAString();
            ras.Reverse(name);
        }
    }
}
