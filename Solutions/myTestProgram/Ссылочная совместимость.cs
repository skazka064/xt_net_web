using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myTest3
{
    class Program
    {
        static void Main(string[] args)
        {

            Human human = new Worker() { Department = "Dev", Name = "Antony", Experience = 15 };
            Worker worker = human as Worker;
            Console.WriteLine(worker.Name);
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

}
