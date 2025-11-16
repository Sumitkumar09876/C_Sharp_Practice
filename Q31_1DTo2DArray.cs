using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Practice
{
    public class OneDTo2DArray
    {
        public void ConvertTo(int rows,int column)
        {
            int[] oneDArray = new int[rows * column];
            for(int i = 0; i < rows * column; i++)
            {
                oneDArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            int[,] twoDArray = new int[rows, column];
            int index = 0;
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < column; j++)
                {
                    twoDArray[i, j] = oneDArray[index];
                    index++;
                }
            }
            foreach(var i in twoDArray)
            {
                Console.WriteLine(i);
            }
        }
    }
    public class Q31_1DTo2DArray
    {
        public static void Main()
        {
            OneDTo2DArray d2 = new OneDTo2DArray();
            d2.ConvertTo(2,3);
        }
    }
}
