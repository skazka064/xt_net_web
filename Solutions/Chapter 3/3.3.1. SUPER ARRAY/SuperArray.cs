using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _3._3._1.SUPER_ARRAY
{
    class SuperArray
    {
       public static void mySuper(int[] myArray, Func<int, int> function)
        {
            if(myArray == null)
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



    }
}
