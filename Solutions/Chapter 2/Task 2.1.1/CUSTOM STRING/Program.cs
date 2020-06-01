﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUSTOM_STRING
{
    class Program
    {
        static void Main(string[] args)
        {
            // проверка поиска символа
            MyStringAsArrayChar stringOne = new MyStringAsArrayChar("myString");
            Console.WriteLine(stringOne.MyFind('S'));
            Console.WriteLine();
          
            // проверка сравнения двух строк
            MyStringAsArrayChar s1 = new MyStringAsArrayChar("Строка");
            Console.Write(s1.MyEquals("Строка"));
            Console.WriteLine();
            // проверка реализации конкатенации

            MyStringAsArrayChar sTestConcat = new MyStringAsArrayChar("Строка");
            Console.WriteLine(sTestConcat.MyConcat("ЕщеОднаСтрока"));
            
            


        }
    }
    class MyStringAsArrayChar
    {
        char[] myChars;

        
        public MyStringAsArrayChar(string s)
            {
                this.myChars = s.ToCharArray();

            }

       //Реализация конкатенации

            public void MyConcatenation(string s)
        {
            
            char[] outChars = s.ToCharArray();

            foreach( char outChar in outChars)
            {
                Console.WriteLine(outChar);
            }
            
            

        }
       
        
        //Реализация сравнения двух строк
        public bool MyEquals(string s)
        {
            char[] outChars = s.ToCharArray();
            
            bool isEqual = Enumerable.SequenceEqual(myChars, outChars);
            
            return isEqual;
        }
       
        //Реализация поиска символа в строке
        public string MyFind(char outChar)
        {        

            string mess = ""; 
            foreach( char x in myChars)
            {
                if (outChar == x)
                {
                    mess = $"Символ {outChar} найден";
                    break;
                }
                else
                {
                    mess = $"Символ {outChar} не найден";
                }
            }

            return mess;
        }

        //Реализация конкатенации
        public char[] MyConcat(string s)
        {
            char[] outChars = s.ToCharArray();
            string inString = String.Concat(myChars);
            string outString = String.Concat(outChars);
            string r = inString + outString;
            char[] rezult = r.ToCharArray();

            return rezult;

        }

       
       
         
    }
}
