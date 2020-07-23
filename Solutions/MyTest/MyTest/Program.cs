using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTest
{
    class Program
    {
        public delegate int Function(int x);
        

        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            
            ApplyToMass(arr, Sqrt);
            
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }

        static int MultiplyToTwo(int A) => A * 2;
        static int Square(int A) => A * A;
        static int Sqrt(int A) => (int) Math.Round(Math. Sqrt(A));
        static void ApplyToMass(int[] arr, Function function)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = function(arr[i]);
            }
            

        }
    }   

}
