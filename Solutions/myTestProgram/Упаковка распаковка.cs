using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myTest1
{
    class Program
    {
        static void DoSomething(object o)
        {

        }
        static void Main(string[] args)
        {
            for (int i = 0; i < 1000000; i++)
            {
                DoSomething(5);
            }
            Worker worker = new Worker();
            int A = 5;
            object obj1 = A;
            object obj2 = A;
            Console.WriteLine(object.ReferenceEquals(obj1, obj2));

            Point p = new Point();
            object obj3 = p;
            object obj4 = p;
            Console.WriteLine(obj3 == obj4);

            Point p1 = (Point)obj3;
            Console.WriteLine(p1);

        }
    }



    class Human
    {
        public string Name;

    }
    class Worker : Human
    {
        public string Department;
        public int Experience;


    }

    class NonWorker : Human
    {
        public string LastWork;
    }

    class Point
    {
        int X;
        int Y;
    }
}
