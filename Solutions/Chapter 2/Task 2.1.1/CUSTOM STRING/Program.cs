using System;
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

            StringAsArrayChar stringOne = new StringAsArrayChar("myString");
            Console.WriteLine(stringOne.MyFind('S')); 
            
        }
    }
    class StringAsArrayChar
    {
        char[] myChars;

        public char MyFind(char ch)
        {
            char myF = ' ';
            foreach( char x in myChars)
            {
                if (x == ch)
                {
                    myF=x;
                }
            }

            return myF;
        }
       
        public StringAsArrayChar(string s) {


            this.myChars = s.ToCharArray();

        }
         
    }
}
