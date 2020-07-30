using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _3._3._2.SUPER_STRING
{
    class Class1
    {
        public string EnRu(string str)
        {
            string  ru =      @"^[А-я]+$";
            string en =      @"^[A-z]+$";
            string nu = @"^[0-9]+$";
            if(Regex.IsMatch(str, ru))
            {
                return "This is Rus";
            }
            else if(Regex.IsMatch(str, en))
            {
                return "This is En";
            }
            else if (Regex.IsMatch(str, nu))
            {
                return "This is Numeric";
            }
            else
            {
                return "This is Mix";
            }
            {

            }
        }

    }
}
