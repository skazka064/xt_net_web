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
            var greaterMommy = new GreaterMommy(2,2,2);
            Console.WriteLine("Please , write type of Monster:");
            var str = Console.ReadLine();
            var type = (MonsterType)Enum.Parse(typeof(MonsterType), str);
            var monster = greaterMommy.CreateAbstractMonster(type);
            monster.Finding();

        }
    }

    // Реализация Интерфейса Двигаться
    public interface IMovable
    {
        int Speed { get; }
        void Move();
    }
   public abstract class AbstractMonster : IMovable
    {
        public virtual int X { get; set; }
        public virtual int Y { get; set; }

        public  int _speed;
        
         public virtual int Speed =>_speed;
        public  AbstractMonster()
        {
                      
        }
        public abstract void Move();
       
        // Поиск Игрока
        public abstract void Finding();
       
        //Сканирование местности
        public abstract void TerrainScaning();

        
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
        // Если нашел банан, то скорость увеличилась на 2
        // Если нашел вишенку, то могу стрелять двумя патронами
        // С одного патрона можно убить одного монстра        

        public  void Runing()
        {
            Console.WriteLine("Я бегу от монстра скорость 10");
        }
    }    
    
    public class GreaterMommy : AbstractMonster
    {
        public override int X { get; set; }
        public override int Y { get; set; }
        private new int _speed;
        public GreaterMommy(int x, int y, int speed)
        {
            X = x;
            Y = y;
            _speed = speed;
        }
        public override void Move()
        {
            Console.WriteLine("Я двигаюсь со скоростью {0}", _speed);
        }

        public override void TerrainScaning()
        {
            Console.WriteLine("Я вижу все, даже за Препятствиями");
           
        }
       
        public override void Finding()
        {
            Console.WriteLine("Я ищу Игрока и ближе 10 метров, начинаю его преследовать");
        }

        public AbstractMonster CreateAbstractMonster(MonsterType type)
        {
            switch (type)
            {
                case MonsterType.CloudOfChaos:
                    return new CloudOfChaos(30, 20,5);
                case MonsterType.HoundPlant:
                    return new HoundPlant(12, 35,9);
                case MonsterType.KickSpirit:
                    return new KickSpirit(11, 11,10);
                case MonsterType.SpaceOgre:
                    return new SpaceOgre(12, 12,10);
                case MonsterType.GreaterMommy:
                    return new GreaterMommy(2, 8,3);
                default: return null;
            }
        }

        
    }
    public class KickSpirit : AbstractMonster
    {

        public override int X { get; set; }
        public override int Y { get; set; }
        private new int _speed;
        public KickSpirit(int x, int y, int speed)
        {
            X = x;
            Y = y;
            _speed = speed;
        }
        public override void Move()
        {
            Console.WriteLine("Я двигаюсь со скоростью {0}", _speed);
        }

        public override void TerrainScaning()
        {
            Console.WriteLine("Я не вижу Игрока за любым Препятствием");
            
        }
        
       public override void Finding()
        {
                Console.WriteLine("Я ищу Игрока и ближе 5 метров, начинаю его преследовать");
        }        
    }

    public class SpaceOgre : AbstractMonster
    {
        public override int X { get; set; }
        public override int Y { get; set; }
        private new int _speed;
        public SpaceOgre(int x, int y, int speed)
        {
            X = x;
            Y = y;
            _speed = speed;
        }
        public override void Move()
        {
            Console.WriteLine("Я двигаюсь со скоростью {0}", _speed);
        }

        public override void TerrainScaning()
        {
            Console.WriteLine("Я не вижу Игрока за любым Препятствием");
        }
       
        public override void Finding()
        {
            Console.WriteLine("Я ищу Игрока и ближе 4 метров, начинаю его преследовать");
        }
    }

    public class CloudOfChaos: AbstractMonster
    {
        public override int X { get; set; }
        public override int Y { get; set; }
        private new int _speed;
        public CloudOfChaos(int x, int y, int speed)
        {
            X = x;
            Y = y;
            _speed = speed;
        }
        public override void Move()
        {
            Console.WriteLine("Я двигаюсь со скоростью {0}", _speed);
        }
        public override void TerrainScaning()
        {
            Console.WriteLine("Я не вижу Игрока за препятствиями, кроме Tree и Water");
        }

        
        public override void Finding()
        {
            Console.WriteLine("Я ищу Игрока и ближе 7 метров, начинаю его преследовать");
        }
    } 
    public class HoundPlant : AbstractMonster
    {
        public override int X { get; set; }
        public override int Y { get; set; }
        private new int _speed;
        public HoundPlant(int x, int y, int speed)
        {
            X = x;
            Y = y;
            _speed = speed;
        }
        public override void Move()
        {
            Console.WriteLine("Я двигаюсь со скоростью {0}", _speed);
        }

        public override void TerrainScaning()
        {
            Console.WriteLine("Я не вижу Игрока за препятствиями, кроме Tree и Water");
        }
        public override void Finding()
        {
            Console.WriteLine("Я ищу Игрока и ближе 3 метров, начинаю его преследовать");
        }

    } 

    public class Stone 
    {
        // Препятствия
        public int X { get; set; }
        public int Y { get; set; }
           public Stone(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    public class Water
    {
        // Препятствия
        public int X { get; set; }
        public int Y { get; set; }
        public Water(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    public class Tree
    {
        // Препятствия
        public int X { get; set; }
        public int Y { get; set; }
    
        public Tree(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    public class House
    {
        // Препятствия
        public int X { get; set; }
        public int Y { get; set; }

        public House( int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    public class Banan
    {
        // Бонусы
        public int X { get; set; }
        public int Y { get; set; }
        public Banan(int x, int y)
        {

            X = x;
            Y = y;
        }
    }

    public class Cherry
    {
        // Бонусы
        public int X { get; set; }
        public int Y { get; set; }
        public Cherry(int x, int y)
        {
            X = x;
            Y = y;

        }
    }

    public class Died
    {
        // если координаты Monster совпадут с координатами Player, то Player = died
    }

    public enum MonsterType
    {
        None,
        KickSpirit,
        SpaceOgre,
        HoundPlant,
        CloudOfChaos,
        GreaterMommy
    }
}