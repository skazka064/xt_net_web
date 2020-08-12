using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTest
{
    class Program
    {

       
        static void Main(string[] args)
        {
           
        }
    }

   public class Student: IComparable
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public int CompareTo(object obj)
        {
            Student student =  (Student) obj;
            if (this.Age > student.Age) return 1;
            else if (this.Age < student.Age) return -1;
            return 0;


        }

    }
  

}
