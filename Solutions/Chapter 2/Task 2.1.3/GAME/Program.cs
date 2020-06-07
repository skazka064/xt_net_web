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
            BasicShip spaceShip   = new BasicShip();
            BasicShip spaceShip1 = new Fighter();
            Fighter spaceShip2 = new Fighter();
           
            Console.WriteLine("---");
            spaceShip.Fly();
            spaceShip1.Fly();
            spaceShip2.Fly();


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

    public class BasicShip
    {
        public void Fly()
        {
            Console.WriteLine("Я Лечу");

        }
    }
  
    public class MotherShip
    {
        public BasicShip createSpaceShip()
        {

        }
    }

    public class Fighter : BasicShip
    {
        public new void Fly()
        {
            Console.WriteLine("Я Лечу");
            Console.WriteLine("Я ищу врагов");
        }

        public void Shoot()
        {
            Console.WriteLine("Boom!");
        }
    }

    public enum SpaceShipType
    {
        SpaceShip,
        Fighter
    }
}
