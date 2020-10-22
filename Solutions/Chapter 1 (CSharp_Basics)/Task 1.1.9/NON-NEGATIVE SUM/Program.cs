using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NON_NEGATIVE_SUM
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, -3, 4, 5, -10 };
            int count = 0;
            for(int i =0; i< array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    count = count + array[i];
                }
            }
            Console.Write(count);
            Console.WriteLine();
        
        }
    }
}
