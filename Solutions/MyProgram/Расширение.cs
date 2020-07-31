using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace myTest2
{

    static class ObjectExtensions
    {
        //Определить расширяющий метод для Syste.Object
        public static void DisplayDefiningAccembly(this object obj)
        {
            Console.WriteLine("{0} lives here: \n\t -> {1}", obj.GetType().Name, Assembly.GetAssembly(obj.GetType()));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Поскольку все типу расширяют System.Object, все классы и структуры могут использовать это расширение
            int myInt = 12345678;
            myInt.DisplayDefiningAccembly();
            System.Data.DataSet d = new System.Data.DataSet();
            d.DisplayDefiningAccembly();
            Console.ReadLine();

        }
    }
}
