using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUM_OF_NUMBERS
{
    class Program
    {
        static void Main(string[] args)
        {
            
                
            int a =3;
            int sum3 = 0;
            for(int i = 0; i<1000; i++)
            {

                if (i % a == 0)
                {
                    sum3 = sum3 + i;
               
                }
                
            }

            int b = 5;
            int sum5 = 0;
            for(int i = 0; i<1000; i++)
            {
                if(i % b == 0)
                {
                    sum5 = sum5 + i;
                }
            }

            Console.Write(sum3+sum5);
            Console.WriteLine();
                          
                
      

        }
    }
}
