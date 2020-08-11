using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace myTest2
{    
    
    class Program
    {
       
        static void Main(string[] args)
        {
             
        }
         
        public class Human
        {
            protected int Age;
        }
        public class Worker : Human
        {
            void DoDo()
            {
                Age = 5;
            }
        }
        public class SuperWorker : Worker
        {
            void DoDo()
            {
                Age = 6;
            }
        }
    }
    
}
