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
            SpaceShip spaceShip   = new SpaceShip();
            SpaceShip spaceShip1 = new Fighter();
            Fighter spaceShip2 = new Fighter();

        }

        #region OVERLOAD
        public static int Sum(int x, int y) => x + y;
       
        public static int Sum(int[] mass)
        {
            var res = 0;

            foreach(var item in mass)
                res += item;
           
            return res;
        }

        #endregion
    }

    public class SpaceShip
    {
        public void Fly()
        {
            Console.WriteLine("Я Лечу");

        }
    }

    public class Fighter : SpaceShip
    {
        public new void Fly()
        {
            Console.WriteLine("Я Лечу");
            Console.WriteLine("Я ищу врагов");
        }
    }
}
