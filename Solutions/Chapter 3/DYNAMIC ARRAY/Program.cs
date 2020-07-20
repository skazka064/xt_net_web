using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DYNAMIC_ARRAY
{
    public class DynamicArray<T> : IEnumerable<T>, IEnumerable, ICloneable
    {
        private T[] MyArray { get; set; }
       
        private int _length;
        private int _capacity;

        public  int Length
        {
            get => _length;
          
            set
            {
                foreach (var item in MyArray)
                {
                    _length = _length++;
                }
            }
            
        }
        public int Capacity
        {
            get => _capacity;
            set
            {
               if(_capacity < _length)
                {
                    throw new ArgumentOutOfRangeException("qqqqq");
                }
              
               else if(_capacity >= _length)
                {
                    T[] myTempArray = new T[_capacity*_capacity];
                    int i = _capacity;
                    
                    foreach (T item in MyArray)
                    {
                        myTempArray[i] = item;
                        i++;
                    }
                   
                    
                    MyArray = new T[_capacity * _capacity];
                    myTempArray.CopyTo(MyArray,0);

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
                T[] myTempArray = new T[Capacity * 2];
                MyArray.CopyTo(myTempArray, 0);
                myTempArray[Length] = item;
                MyArray = myTempArray;
                Capacity = Capacity * 2;
            }
            else if (Capacity > Length)
            {
                MyArray[Length] = item;
            }
            Length++;

        }
        public void AddRange(ICollection<T> myCollection)
        {
            if(myCollection.Count>=Capacity)
            {
                Capacity = Capacity + myCollection.Count;
            }
            foreach(var myItem in myCollection)
            {
                MyArray[Length] = myItem;
                Length++;
            }
        }
        public bool Remove(T myItem)
        {
            for(int i =0; i < Length; i++)
            {
                if (MyArray[i].Equals(myItem))
                {
                    for(int j=i; j<Length -1; j++)
                    {
                        MyArray[i] = MyArray[j + 1];

                    }
                    Length = Length - 1;
                    return true;
                }
                
            }
            return false;
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
        public T this[int index]
        {
            get
            {
                if (index < -Length || index > Length - 1)
                    throw new ArgumentOutOfRangeException("ArgumentOutOfRangeException");
                else
                    if (index < 0)
                    return MyArray[index + Length];
                else
                    return MyArray[index];
            }
            set
            {
                if (index < -Length || index > Length - 1)
                    throw new ArgumentOutOfRangeException("ArgumentOutOfRangeException");
                else
                    if (index < 0)
                    MyArray[index + Length] = value;
                else
                    MyArray[index] = value;
            }
        }
    }

    

    class Program
    {
       
        static void Main(string[] args)
        {



            DynamicArray<int> myArr = new DynamicArray<int>();

          
          

        }
    }
}
