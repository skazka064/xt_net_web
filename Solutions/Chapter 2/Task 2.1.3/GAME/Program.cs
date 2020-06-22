using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
       public int X { get; set; }
       public int Y { get; set; }


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
        public int  X{ get;set;}
        public int Y { get; set; }


        public  Monster(int x, int y)
        {
            X = x;
            Y = y;
        }
       public void Finding()
        {
                Console.WriteLine("Я ищу Игрока");

        }
        
    }

    public class Monster1 
    {
        
    }

    public class Monster2
    {
    
    }
        
 

    public class Monster3
    {


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

    public enum MonsterType
    {
        None,
        Monster1,
        Monster2,
        Monster3
    }
}