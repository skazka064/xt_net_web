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
    public class DynamicArray<T> : IEnumerable<T>, IEnumerable
    {

        private int _length = 0;
        private int _capacity = 8;
        private T[] _array;

       
        public int Capacity
        {
            get => _capacity;
            protected set => _capacity = value;
        }
        public int Length
        {
            get => _length;
            protected set => _length = value;
        }
        public DynamicArray()
        {
            _array = new T[_capacity];
            
        }
        public DynamicArray(int n)
        {
            _capacity = n;
            _array = new T[n];
            
        }

        public DynamicArray(IEnumerable<T> myCollection)
        {
            int i = 0; 
            foreach(var item in myCollection)
            {
                _array[i] = item;
                i++;
                Length++;
                _capacity++;
            }
           
        }

        public void  Add(T item)
        {
            if (Length==Capacity)
            {
                T[] new_array = new T[Capacity * 2];

                for (int i = 0; i < _array.Length; i++)
                {
                    new_array[i] = _array[i];
                    
                }
                _array = new_array;

            }
            _array[Length] = item;
            Length++;

        }
        public void AddRange(IEnumerable<T> item)
        {
            int tempCount = 0;
            foreach(var i in item)
            {
                tempCount++;
            }
            if ((Length + tempCount) > Capacity)
            {
                T[] new_array = new T[Length + tempCount];
                for (int i = 0; i < _array.Length; i++)
                {
                    new_array[i] = _array[i];
                }
                _array = new_array;
            }
            int anotherCount = Length + tempCount;
            foreach (var i in item)
            {
                _array[anotherCount] = (T)item;
                anotherCount++;
                Length++;

            }

        }

        public bool Remove(T item)
        {
            int i = 0;
            foreach (var arr in _array)
            {
               
                if (arr.Equals(item))
                {
                    T[] new_array = new T[i];
                    for (int j = 0; j < _array.Length; j++)
                    {
                        new_array[j] = _array[j];

                    }
                    

                }
                i++;
            }
            return false;
        }



        public IEnumerator<T> GetEnumerator()
        {
            foreach (T i in _array)
            {
                yield return i;
            }
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
            DynamicArray<int> myArr = new DynamicArray<int>();
            myArr.Add(3);
            myArr.Add(1);
            myArr.Add(3);
            myArr.Add(4);
            myArr.Add(3);
            myArr.Add(4);
            myArr.Add(3);
            myArr.Add(6);
            myArr.Add(6);
            foreach (var item in myArr)
            {
                    Console.WriteLine(item);
            }

            





        }
    }
}
