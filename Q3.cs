
//Create a class `Calculator` that has two `Add` methods: one that takes two `int`s and one that takes two `double`s.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Practice
{
    sealed class FinalReport
    {

    }
    public class Calculator//:FinalReport Inheritance of Sealed class is not possible
    {
        public int Add(int num1,int num2)
        {
            return num1 + num2;
        }
        public double Add(double num1,double num2)
        {
            return num1 * num2;
        }
    }
        public class CalculatorProgram
        {
            public static void Main()
            {
                Calculator cl = new Calculator();
                Console.WriteLine(cl.Add(5, 10));
                Console.Write(cl.Add(10.0, 10.0));
            }
        }
}
