using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MyTest
{
    class Program
    {   
        
        static int TestDelegate(CountDelegate method, string testString)
        {
            return method(testString);
        }
        static void Main(string[] args)
        {
           // Создаем объект, т.к. без создания объекта работают только статические классы
            StringHelper helper = new StringHelper();
            // Создаем два объекта типа CountDelegate и кладем в них ссылки объекта типа StringHelper
            CountDelegate d1 = helper.GetCount;
            CountDelegate d2 = helper.GetCountSymbolA;
            string testString = "LAMP";
            Console.WriteLine("Общее количество символов: {0} ", TestDelegate(d1, testString));
            Console.WriteLine("Количество символов А : {0}", TestDelegate(d2, testString));


        }
    }

    // Создаем делегат
    public delegate int CountDelegate(string message);
    
    // Здесь тестовые методы, берем их отсюда
    public class StringHelper
    {
        public int GetCount(string inputString)
        {
            return inputString.Length;
        }

        public int GetCountSymbolA(string inputString)
        {
            return inputString.Count(c => c == 'A');
        }

    }
}