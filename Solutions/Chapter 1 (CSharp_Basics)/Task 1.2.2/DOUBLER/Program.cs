using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOUBLER
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первую строку: ");
            StringBuilder strOne = new StringBuilder(Console.ReadLine());
            Console.WriteLine();            
            Console.WriteLine("Введите вторую строку: ");
            string strTwo = Console.ReadLine();
            
            char[] doubler = strTwo.ToCharArray();
            
            for(int i = 0; i < strOne.Length; i++)
            {
                for(int j =0; j < strTwo.Length; j++)
                {
                    if(strOne[i] == strTwo[j])
                    {
                        strOne.Insert(i, strTwo[j]);

                        i++;
                    }

                }
            }
            Console.WriteLine(strOne);
            Console.Read();

        }
    }
}
