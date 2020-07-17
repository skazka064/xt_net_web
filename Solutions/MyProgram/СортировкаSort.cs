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
            Student student1 = new Student() { Age = 19, Name = "Nicolas" };
            Student student2 = new Student() { Age = 18, Name = "Volga" };
            Console.WriteLine(student1.CompareTo(student2));
            Student[] students = new Student[] { student1, student2 };
            Array.Sort(students);
            
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