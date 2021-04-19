using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleLectionEvent
{
    class Program
    {
        static void Main(string[] args)
        {
            MotherShip BaseShip = new MotherShip();
            BaseShip.CreateShip(ShipType.Engineer);
            BaseShip.CreateShip(ShipType.Fighter);
            BaseShip.CreateShip(ShipType.Fighter);
            foreach(var item in BaseShip.Ships)
            {
                Console.WriteLine(item);
            }
        }
    }

    public class MotherShip
    {
        public List<AbstractSpaceShip> Ships { set;get ;}
       public MotherShip()
        {
            Ships = new List<AbstractSpaceShip>();
        }

        
        public AbstractSpaceShip CreateShip(ShipType type)
        {
            AbstractSpaceShip ship;
            switch (type)
            {
                case ShipType.Fighter: ship = new Fighter(this); break;
                case ShipType.Engineer: ship = new Engineer(this); break;
                default: throw new ArgumentException("Unknown Spaceship", "type"); 
            }
            Ships.Add(ship);
            return ship;
        }

        public void RemoveShip(AbstractSpaceShip ship)
        {
            Ships.Remove(ship);
        }
        
    }
    public abstract class AbstractSpaceShip
    {
        MotherShip BaseShip { get; set; }

        public int MaxHP { get; } = 100;
        private int hp;
        public int HP { get =>hp;

            set
            {
                hp = value;
                if (hp <= 0)
                    Destroy();
            } 
        }
        public AbstractSpaceShip(MotherShip baseShip)
        {
            hp = MaxHP;
            BaseShip = baseShip;
        } 
        public void Damage(int damage)
        {

            hp -= damage;
        }
        public void Destroy()
        {
            BaseShip.RemoveShip(this);
        }
    }
    public class Fighter : AbstractSpaceShip
    {
        public Fighter(MotherShip mother) : base(mother)
        {
        }
    }
    public class Engineer : AbstractSpaceShip
    {
        public Engineer(MotherShip mother) : base(mother)
        {
        }
    }

    public enum ShipType
    {
        Fighter,
        Engineer,
        None
    }


}
