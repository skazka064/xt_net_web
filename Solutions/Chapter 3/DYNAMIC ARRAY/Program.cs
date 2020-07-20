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

        public  int Lenght
        {
            get
            {
                return  MyArray.Length;
            }
            
        }
        public int Capacity
        {
            get
            {
                return MyArray.Length;
            }
            set
            {

            }
        }

        public DynamicArray()
        {
            MyArray = new T[8];
            Capacity = 8;
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
