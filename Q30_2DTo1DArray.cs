using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Practice
{
    public class TwoDTo1DArray
    {
        public void Convert2DTo1D()
        {
            int[,] twoDArray = new int[2, 3];
            Console.WriteLine("Enter the values:");
            for(int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    twoDArray[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            int rowlength = twoDArray.GetLength(0);
            int columnlength = twoDArray.GetLength(1);
            int[] oneDArray = new int[rowlength * columnlength];
            int index = 0;
            for(int i = 0; i < rowlength; i++)
            {
                for(int j = 0; j < columnlength; j++)
                {
                    oneDArray[index] = twoDArray[i, j];
                    index++;
                }
            }
            foreach(var i in oneDArray)
            {
                Console.WriteLine(i);
            }
        }
    }

    public class Q30_2DTo1DArray
    {
        public static void Main(string[] args)
        {
            TwoDTo1DArray d1 = new TwoDTo1DArray();
            d1.Convert2DTo1D();
        }
    }
}
