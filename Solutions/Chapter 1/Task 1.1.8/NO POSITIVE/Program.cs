using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO_POSITIVE
{
    class Program
    {
        static void Main(string[] args)
        {

int[,,] array = new int[,,] { { { 1, 2, 3 }, { 4, 5, 6 },{ -7,-8,-9} }  ,    { { 7, 8, 9 }, { 10, 11, 12 },{ -10,-11,-12} }  ,  { { 7, 8, 9 }, { 10 , 11, 12 }, { -10, -11, -12 } } };

            Console.Write(array.Rank);
            Console.WriteLine();
    // Проходим слой за слоем
    for (int i =0; i < 3; i++)
            {
                  for(int j =0; j<3; j++)
                {
                    for(int k =0; k<3; k++)
                    {


                        if (array[i,  j,  k] > 0)
                        {
                            array[i, j, k] = 0;
                        }
                    
                    }
                     
                }
            }


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        Console.Write(array[i, j, k]);
                        Console.WriteLine();
                    }

                }
            }


        }
    }
}
