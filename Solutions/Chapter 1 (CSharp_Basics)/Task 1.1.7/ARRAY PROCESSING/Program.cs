using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARRAY_PROCESSING
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random rando = new Random();
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = rando.Next();
                
            }

            for(int i = 0; i<array.Length; i++)
            {
                for(int j = 0; j<array.Length; j++)
                {
                 
                    int n;
               
                if (array[i] > array[j])
                {
                    n = array[j];
                    array[j] = array[i];
                    array[i] = n;
                }
                }
               

            }


            int max = 0;
            for(int i = 0; i<array.Length; i++)
            {
                if (array[i] > max) max = array[i]; 
            }

            int min = array[0];
            for(int i = 0; i<array.Length; i++)
            {
                if (array[i] < min) min = array[i];
            }
            
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.Write(max);
            Console.WriteLine();
            Console.Write(min);
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
