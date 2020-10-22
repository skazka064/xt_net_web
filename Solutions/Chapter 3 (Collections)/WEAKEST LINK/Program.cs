using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace WEAKEST_LINK
{
	class Program
    {

        public static void Main()
        {
            Console.WriteLine("Введите N:");
            int n = Convert.ToInt32(Console.ReadLine()) ;
            Console.WriteLine("ВЫВОД: Сгенерирован круг людей. Начинаем вычеркивать каждого второго.");

            int k = 2;
            Queue<int> ring = new Queue<int>(Enumerable.Range(1, n));
            int iter = 1;
            while (ring.Count != 1)
            {
                
                for (int i = 1; i <= k; ++i)
                {
                    int x = ring.Dequeue();
                    if (i != k)
                    {
                       
                       /*if(ring.Count!=1) Console.WriteLine($"Убиваем {x} воина");*/
                        ring.Enqueue(x);
                        
                    }

                    
                }
                Console.WriteLine("Раунд {0}. Вычеркнут человек. Людей осталось: {1}",iter, ring.Count);
           iter++;
            }
            Console.WriteLine("Остался номер {0} ",ring.Dequeue());
           
        }
    }
    

}