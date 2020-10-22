using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOWERCASE
{
    class Program
    {
        static void Main(string[] args)
        {
            string s  = "Антон выпил кофе и послушал Стинга";
            string s2 = "Антон хорошо начал утро: послушал Стинга, выпил кофе и посмотрел Звёздные Войны";
            String[] words1 = s.Split(new char[] { ' ', ',' });
            string[] separators = { ",", ".", "!", "?", ";", ":", " " };
            string[] words2 = s2.Split(separators, StringSplitOptions.RemoveEmptyEntries); // Необходимо было добавить эту опцию.... -2 часа поиска
            int count =0;
            int count2 = 0;
            foreach(string word in words1)
            {
                char[] ch = word.ToCharArray();
                if (!char.IsUpper(ch[0]))
                {
                    count = count + 1;                   

                }
                }

            foreach(string word2 in words2)
            {
                
                char[] ch2 = word2.ToCharArray();
                if (!char.IsUpper(ch2[0]))
                {
                    count2 = count2 + 1;

                }

            }

            Console.WriteLine(count);
            Console.WriteLine();
            Console.WriteLine(count2);
            Console.WriteLine();
        }

        }
    }

