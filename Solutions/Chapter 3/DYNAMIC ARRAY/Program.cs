using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        public  int Length
        {
            get
            {
                return  MyArray.Length;
            }
            set
            {
                Length = value;
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
                if(MyArray == null)
                {
                    MyArray = new T[value];
                }
                else if(value>= Length)
                {
                    T[] myTempArray = MyArray;
                    MyArray = new T[value];
                    myTempArray.CopyTo(MyArray, 0);
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
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
            Capacity = n;
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
            Capacity = Size;
        }

        public void  Add(T item)
        {
            if(Length == Capacity)
            {
                Capacity = Capacity * 2;
            }

            MyArray[Length] = item;
            Length++;

        }
        public void AddRange(ICollection<T> myCollection)
        {
            if(myCollection.Count>=Capacity)
            {
                Capacity = Capacity + myCollection.Count;
            }
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

            Collection<int> c = new Collection<int>();
            c.Add(1);
            DynamicArray<IEnumerable> collection = new DynamicArray<IEnumerable>();
            Console.WriteLine(collection.Capacity);

            DynamicArray<int> d = new DynamicArray<int>(9);
            Console.WriteLine(d.Capacity);

        }
    }
}
