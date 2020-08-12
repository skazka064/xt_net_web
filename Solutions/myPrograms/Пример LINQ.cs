using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myTest2
{
    class Program
    {
        public static float Mode(float[] array)
        {
            var groups = array.GroupBy(v => v);
            float maxCount = groups.Max(g => g.Count());
            return groups.First(g => g.Count() == maxCount).Key;
        }
        static void Main(string[] args)
        {
            float [] teams = { 1, 1, 2, 2, 2, 3 };

            Console.WriteLine(Mode(teams));
            

        }
    }
}
