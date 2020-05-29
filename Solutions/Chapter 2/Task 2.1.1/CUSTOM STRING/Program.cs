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
            Console.WriteLine(stringOne.MyFind('q')); 
            
        }
    }
    class StringAsArrayChar
    {
        char[] myChars;
         public StringAsArrayChar(string s)
            {
                this.myChars = s.ToCharArray();

            }
        public string MyFind(char ch)
        {        

            string mess = "Символ не найден"; 
            foreach( char x in myChars)
            {
                if (x == ch)
                {
                    mess = $"Символ {ch} найден";
                }
                else
                {
                    mess = $"Символ {ch} не найден";
                }
            }

            return mess;
        }
       
       
         
    }
}
