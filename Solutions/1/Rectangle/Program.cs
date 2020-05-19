using System;
using System.Security.Cryptography.X509Certificates;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            if ( a<=0 )
            {
                Console.WriteLine("Вы ввели некорректное значение");
            }
            int b = int.Parse(Console.ReadLine());
            if (b <= 0)
            {
                Console.WriteLine("Вы ввели некорректное значение");
            }


            Console.WriteLine(a*b);
        }
    }
}
