using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3._1.SUPER_ARRAY
{

    class Program
    {
        static void Main(string[] args)
        {
            int[] teams = { 1, 1, 1, 2, 2, 3, 4, 7, 8 };
            Console.WriteLine(SuperArray.RecurringElement(teams));
            Console.WriteLine(SuperArray.Avg(teams));
            Console.WriteLine(SuperArray.Sum(teams));
            
        }
    }
}
