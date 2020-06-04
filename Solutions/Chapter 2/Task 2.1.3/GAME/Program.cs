using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAME
{
    class Program
    {
        static void Main(string[] args)
        {
            Sum(1, 2);
            Sum(new int[]{ 1,2});

        }

        public static int Sum(int x, int y) => x + y;
       
        public static int Sum(int[] mass)
        {
            var res = 0;

            foreach(var item in mass)
                res += item;
           
            return res;
        }
    }
}
