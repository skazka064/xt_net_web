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
        private T[] MyArray { get; set; }
        public int Length { get; set; }
        public int Capacity
        {
            get
            {
                return MyArray.Length;
            }
            set
            {
                MyArray = new T[value];
            }
        }
        public DynamicArray()
        {
            MyArray = new T[8];
        }
        public DynamicArray(int n)
        {
            MyArray = new T[n];
        }

        public DynamicArray(IEnumerable<T> myCollection)
        {
            int Size = myCollection.Count();
            MyArray = new T[Size];
            int i = 0;
            foreach(var myC in myCollection)
            {
                MyArray[i] = myC;
                i++;
            }
        }

        public void  Add(T item)
        {
                if Lenght == Capacity

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
       
        static void Main(string[] args)
        {
            
            

        }
    }
}
