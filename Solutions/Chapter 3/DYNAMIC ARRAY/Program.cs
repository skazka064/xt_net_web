using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DYNAMIC_ARRAY
{
    public class DynamicArray<T> : IEnumerable<T>, IEnumerable, ICloneable
    {
        private T[] Arr { get; set; }
        public DynamicArray()
        {
            Arr = new T[8];
        }
        public object Clone()
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }



    class Program
    {
        static void PrintCollection<T>(T[] mass)
        {
            Console.WriteLine("Дженерик");
            Console.WriteLine(mass[0]);
        }
        /*static void PrintCollection(int[] mass)
        {
            Console.WriteLine("Обычный метод");
            Console.WriteLine(mass[0]);
        }*/
        static void Main(string[] args)
        {

            int[] massInt = new int[2];
            PrintCollection(massInt);

        }
    }
}
