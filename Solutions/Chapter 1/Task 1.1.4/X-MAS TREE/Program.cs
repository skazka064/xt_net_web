using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X_MAS_TREE
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int N = int.Parse(Console.ReadLine());
                // int k = 1;
                for (int i = 1; i <= N; i++)
                {
                    for (int k = 1; k <= 2 * i; k += 2)
                    {
                        for (int j = N; j >= k / 2 + 2; j--)
                        {
                            Console.Write(' ');
                        }

                        for (int j = 1; j <= k; j++)
                        {
                            Console.Write('*');
                        }

                        Console.WriteLine();
                    }
                }
            }
            catch
            {
                Console.WriteLine("Ошибка");
            }

        }
    }
}
