using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleLectionDelegate
{
    class Program
    {
        public delegate int Function(int x);
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4 };
            ApplyToMass(arr, Sum);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
        static int Sum(int x) => x + x;
       
        static void ApplyToMass(int[] mass, Function function) 
        {
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = function(mass[i]);
            }

        }
    }
}
