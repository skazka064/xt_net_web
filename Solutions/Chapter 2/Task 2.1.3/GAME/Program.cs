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
            var player = new Player(1,1);
            var monster = new Monster(2, 2);

        }
    }

    public class Player
    {
        private int _x;

        public int X
        {
            get { return _x; }
            set { _x = value; }
        }
        private int _y;

        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public Player(int x, int y)
        {
            X = x;
            Y = y;
        }
        public void Runing()
        {
            Console.WriteLine("Я бегу от монстра");
        }
    }
    public class Monster
    {
        private int _x;

        public int X
        {
            get { return _x; }
            set { _x = value; }
        }
        
        private int _y;
                public int Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public Monster(int x, int y)
        {
            X = x;
            Y = y;
        }
       public void Finding()
        {
                Console.WriteLine("Я ищу Игрока");

        }
        
    }

    public class Stone 
    {
        // Препятствия
    }

    public class Apple
    {
        // Бонусы
    }

    public class Died
    {
        // если координаты Monster совпадут с координатами Player, то Player = died
    }
}