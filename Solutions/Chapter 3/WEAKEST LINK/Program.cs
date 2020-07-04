using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEAKEST_LINK
{
	class Program
    {
        static void Main(string[] args)
        {
            Logic play = new Logic();

            while (true)
            {
                Console.WriteLine("Please, enter count of people");

                if (int.TryParse(Console.ReadLine(), out int x) && x > 0)
                {
                    Console.WriteLine("Please, enter number cross out a person");

                    if (int.TryParse(Console.ReadLine(), out int y) && y > 0)
                    {
                        play.PeopleCrossOut(x, y);
                    }
                }
            }
        }
    }

    public class Logic
    {
        public void PeopleCrossOut(int n, int number)
        {
            int round = 1;

            int summOfPeople = n; // Needed to be split variable

            do
            {
                for (int i = 1; i <= n; i++)
                {
                    if (i % number == 0)
                    {
                        --summOfPeople;
                    }
                }

                if (summOfPeople == n)
                {
                    Console.WriteLine("Невозможно вычеркнуть человека");
                    summOfPeople = 1;
                }
                else
                {
                    Console.WriteLine($"Раунд {round}. Вычеркнут человек(-и). Людей осталось: {summOfPeople}");
                    n = summOfPeople;
                    round++;
                    Console.ReadKey(); // In the task writed "Poetapno" to show a result
                }
            }
            while (summOfPeople != 1);
        }
    }
}