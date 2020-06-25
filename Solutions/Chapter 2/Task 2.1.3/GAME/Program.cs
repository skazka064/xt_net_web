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
            var greaterMommy = new GreaterMommy(2, 2);
            Console.WriteLine("Please , write type of Monster:");
            var str = Console.ReadLine();
            var type = (MonsterType)Enum.Parse(typeof(MonsterType), str);
            var monster = greaterMommy.CreateAbstractMonster(type);
            monster.Finding();

        }
    }

   public abstract class AbstractMonster
    {
         int X { get; set; }
         int Y { get; set; }
        public  AbstractMonster(int x, int y)
        {
            X = x;
            Y = y;
        }

        //Бег
         public abstract void Runing();
       
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
        public int X { get; set; }
        public int Y { get; set; }

        public GreaterMommy(int x, int y) : base(x, y) { }

        public override void TerrainScaning()
        {
            Console.WriteLine("Я вижу все, даже за Препятствиями");
           
        }
        public override void Runing()
        {
            Console.WriteLine("Я  бегу,  за игроком скорость 3");
        }
        public override void Finding()
        {
            Console.WriteLine("Я ищу Игрока и ближе 10, начинаю его преследовать");
        }

        public AbstractMonster CreateAbstractMonster(MonsterType type)
        {
            switch (type)
            {
                case MonsterType.CloudOfChaos:
                    return new CloudOfChaos(30, 20);
                case MonsterType.HoundPlant:
                    return new HoundPlant(12, 35);
                case MonsterType.KickSpirit:
                    return new KickSpirit(11, 11);
                case MonsterType.SpaceOgre:
                    return new SpaceOgre(12, 12);
                default: return null;
            }
        }

         
    }
    public class KickSpirit : AbstractMonster
    {
        public int  X{ get;set;}
        public int Y { get; set; }

        public KickSpirit(int x, int y) : base(x, y) { }

        public override void TerrainScaning()
        {
            Console.WriteLine("Я не вижу Игрока за любым Препятствием");
            
        }
        public override void Runing()
        {
            Console.WriteLine("Я  бегу, за игроком скорость 8");
        }
       public override void Finding()
        {
                Console.WriteLine("Я ищу Игрока и ближе 5, начинаю его преследовать");
        }        
    }

    public class SpaceOgre : AbstractMonster
    {
        public int X { get; set; }
        public int Y { get; set; }

        public SpaceOgre(int x, int y) : base(x, y) { }

        public override void TerrainScaning()
        {
            Console.WriteLine("Я не вижу Игрока за любым Препятствием");
        }
        public override void Runing()
        {
            Console.WriteLine("Я  бегу,  за игроком скорость 9");
        }
        public override void Finding()
        {
            Console.WriteLine("Я ищу Игрока и ближе 4, начинаю его преследовать");
        }
    }

    public class CloudOfChaos: AbstractMonster
    {
        public int X { get; set; }
        public int Y { get; set; }

        public CloudOfChaos(int x, int y) : base(x, y) { }
        public override void TerrainScaning()
        {
            Console.WriteLine("Я не вижу Игрока за препятствиями, кроме Tree и Water");
        }

        public override void Runing()
        {
            Console.WriteLine("Я  бегу,  за игроком скорость 8");
        }
        public override void Finding()
        {
            Console.WriteLine("Я ищу Игрока и ближе 7, начинаю его преследовать");
        }
    } 
    public class HoundPlant : AbstractMonster
    {
        public int X { get; set; }
        public int Y { get; set; }


        public HoundPlant(int x, int y) : base(x, y) { }
        
        public override void Runing()
        {
            Console.WriteLine("Я  бегу,  за игроком скорость 12");
        }

        public override void TerrainScaning()
        {
            Console.WriteLine("Я не вижу Игрока за препятствиями, кроме Tree и Water");
        }
        public override void Finding()
        {
            Console.WriteLine("Я ищу Игрока и ближе 3, начинаю его преследовать");
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