using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleLectionExtensionAndLONQ
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mass = new int[] { 1, 2, 3, 4, 5, 6, 12 };

        }
    }

    public static class Int32ArrayExtensions
    {
     
        public static int Average(int[] mass)
        {
            if (mass == null || mass.Length == 0)
                throw new ArgumentException("'mass' argument cannot be null or empty");
            var sum = 0;
            foreach (var item in mass)
            {
                sum += item;
                
            }
            return sum / mass.Length;
        }
        public static void Modify(int[] mass, Func<int,int> modification)
        {
           if(mass==null || mass.Length==null)
            {
                throw new ArgumentException("'mass' argument cannot be null or empty");
            }
            var sum = 0;

            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = modification(mass[i]);

            }
        }

    }
}
