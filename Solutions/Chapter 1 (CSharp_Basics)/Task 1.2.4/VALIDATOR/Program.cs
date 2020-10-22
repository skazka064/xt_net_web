using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VALIDATOR
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "я плохо учил русский язык. забываю начинать предложения с заглавной. хорошо, что можно написать программу!";
            string[] separators = { ".","?","!"};
            string[] offers = s.Split(separators, StringSplitOptions.RemoveEmptyEntries);
           

            for (int i =0; i< offers.Length; i++)
            {
                offers[i] = offers[i].Trim();
                offers[i] = (string)(offers[i].Remove(1, offers[i].Length - 1)).ToUpper() + offers[i].Remove(0, 1);
                Console.WriteLine(offers[i]);
                Console.WriteLine();
               
                
                
            }

        }
    }
}
