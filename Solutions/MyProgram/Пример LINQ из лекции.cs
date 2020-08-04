using System;
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
            int[] arr = { -5, 7, -4, 6, 2, 8, 9, -1 };
            var res = from n in arr
                      where n > 0
                      select n;
            Console.WriteLine(res.Count());
            arr[0] = 1;
            Console.WriteLine(res.Count());
           
        }
        
    }
}
