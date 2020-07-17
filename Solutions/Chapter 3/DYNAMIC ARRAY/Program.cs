using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DYNAMIC_ARRAY
{
    public class DynamicArray<T> : IEnumerable<T>, IEnumerable, ICloneable
    {
        private T[] MyArr { get; set; }
        public DynamicArray()
        {
            MyArr = new T[8];
        }
        public DynamicArray(int n)
        {
            MyArr = new T[n];
        }

        public DynamicArray(IEnumerable<T> myCollection)
        {
            int Size = myCollection.Count();
            MyArr = new T[Size];
            int i = 0;
            foreach(var myC in myCollection)
            {
                MyArr[i] = myC;
                i++;
            }
        }

        public void  Add(T item)
        {
                        

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
