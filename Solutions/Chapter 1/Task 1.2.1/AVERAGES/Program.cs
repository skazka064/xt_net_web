using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVERAGES
{
    class Program
    {
        static void Main(string[] args)
        {
            String str = "Викентий хорошо отметил день рождения: покушал пиццу, посмотрел кино, пообщался со студентами в чате";

            String[] words = str.Split( new char[] {' ', ','});
            int count = 0;
            foreach (var value in words)
            {
                count = count + value.Length;
                Console.WriteLine(value);
            }
          
            Console.WriteLine(count/14);
        }
    }
}
