using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_ARRAY
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[2,3] { { 1, 2 ,3} , { 4, 5,6 } };
            int count = 0;
            for (int i = 0; i <=1; i++)
            {
                for (int j = 0; j <=2; j++)
                {
                    if ((i+j)%2==0)
                    {
                       count= count+ array[i, j];
                       
                    }

                }

            }
                        Console.Write(count);
                        Console.WriteLine();
            
        }
    }
}
