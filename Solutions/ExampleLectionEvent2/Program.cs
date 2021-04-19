using System;
using System.Collections.Generic;


namespace ExampleLectionEvent2
{
    class Program
    {
        static void Main(string[] args)
        {
            MotherShip motherShip = new MotherShip();
            var fighter1 = motherShip.CreateShip(ShipType.Fighter);
            var fighter2 = motherShip.CreateShip(ShipType.Fighter);
            var fighter3 = motherShip.CreateShip(ShipType.Fighter);
            var engineer1 = motherShip.CreateShip(ShipType.Engineer);
            foreach(var item in motherShip.Ships)
            {
                Console.WriteLine(item);
            }
            fighter2.Damage(100);
            engineer1.Damage(100);
            foreach (var item in motherShip.Ships)
            {
                Console.WriteLine(item);
            }

        }
    }

    public class MotherShip
    {
        public List<AbstractSpaceShip> Ships { set; get; }
        AbstractSpaceShip ship;
        public MotherShip()
        {
            Ships = new List<AbstractSpaceShip>();
        }

        public AbstractSpaceShip CreateShip(ShipType type)
        {
            switch (type)
            {
                case ShipType.Engineer: ship = new Engineer(); break;
                case ShipType.Fighter: ship = new Fighter(); break;
                default: throw new ArgumentException("Unknown argument", "type");

            }
            Ships.Add(ship);
            ship.onDestroy += RemoveShip;



            return ship;
        }

        public void RemoveShip(AbstractSpaceShip ship)
        {
            Ships.Remove(ship);
            ship.onDestroy -= RemoveShip;
        }
    }
        public abstract class AbstractSpaceShip
        {
            public event Action<AbstractSpaceShip> onDestroy = delegate { };
            public int MaxHP { get; } = 100;
            private int hp;
           public int HP
            {
                get { return hp; }
                set
                {
                    hp = value;
                    if (hp <= 0)
                        Destroy();

                }
            }
            public AbstractSpaceShip()
            {
                HP = MaxHP;
            }
            public void Damage(int d)
            {
                HP= HP- d;
            }

            private void Destroy()
            {
                onDestroy?.Invoke(this);
            }


        }

        public class Fighter : AbstractSpaceShip
        {
            
        }

        public class Engineer : AbstractSpaceShip
        {
           
        }
public enum ShipType
        {
            Fighter,
            Engineer,
            None
        }

    }
    

