using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Practice
{
    public class Person1
    {
        public string name { get; set; }
        public int age { get; set; }
        public Person1():this("Unknown",0)
        {

        }
        public Person1(string name) : this(name, 0)
        {
        }
        public Person1(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
     }
    public class Program2
    {
        public static void Main(string[] args)
        {
            Person1 pr1 = new Person1("Sumit", 23);
            Person1 pr2 = new Person1("Sumit", 23);
            Person1 pr3 = new Person1();
        }
    }
    
}
