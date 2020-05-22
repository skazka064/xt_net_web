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
            int[,] array = new int[,] { { 1, 2 ,3} , { 4, 5,6 } };
            int count = 0;
            Console.Write(array.Rank);
            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i<array.Length; i++)
            {
                for(int j =0; j<array.Length; j++)
                {
                    

                        Console.Write(j);
                        Console.WriteLine();
                    
                }

            }
        }
    }
}
