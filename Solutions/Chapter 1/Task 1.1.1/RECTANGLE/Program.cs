using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RECTANGLE
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            if (a <= 0)
            {
                Console.WriteLine("Вы ввели некорректное значение");
            }
            int b = int.Parse(Console.ReadLine());
            if (b <= 0)
            {
                Console.WriteLine("Вы ввели некорректное значение");
            }


            Console.WriteLine(a * b);
            Console.ReadLine();
        }
    }
}
