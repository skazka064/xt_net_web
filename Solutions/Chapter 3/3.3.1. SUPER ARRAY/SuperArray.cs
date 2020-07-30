using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _3._3._1.SUPER_ARRAY
{
    public static  class SuperArray
    {
        internal static void mySuper(int[] myArray, Func<int, int> function)
        {
            if (myArray == null)
            {
                throw new ArgumentNullException();
            }
            else
            {
                for (int i = 0; i < myArray.Length; i++)
                {
                    myArray[i] = function(myArray[i]);
                }
            }
        }



        public static int Sum(this int[] array)
        {
            int sum = 0;
            foreach (int item in array)
            {
                sum += item;
            }
            return sum;
        }

        public static int Avg(this int [] array) => array.Sum() / array.Length;
        public static int RecurringElement(int[] array)
        {
            var groups = array.GroupBy(v => v);
            int maxCount = groups.Max(g => g.Count());
            return groups.First(g => g.Count() == maxCount).Key;
        }





    }
}
