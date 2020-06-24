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

   public abstract class Unit
    {
         int X { get; set; }
         int Y { get; set; }
         public abstract void Runing();
       

    }

    public class Player : Unit
    {
       public int X { get; set; }
       public int Y { get; set; }

        public Player(int x, int y)
        {
            X = x;
            Y = y;
        }
        // Если нашел банан, то скорость увеличилась на 2
        // Если нашел вишенку, то могу стрелять двумя патронами
        // С одного патрона можно убить одного монстра 
       

        public override void Runing()
        {
            Console.WriteLine("Я бегу от монстра скорость 10");
        }
    }
    public class Monster : Unit
    {
        public int  X{ get;set;}
        public int Y { get; set; }


        public  Monster(int x, int y)
        {
            X = x;
            Y = y;
        }
        public override void Runing()
        {
            Console.WriteLine("Я тоже бегу, но за игроком скорость 11");
        }
       public void Finding()
        {
                Console.WriteLine("Я ищу Игрока и ближе трех, начинаю его преследовать");

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

    public class Banan
    {
        // Бонусы
    }

    public class Cherry
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