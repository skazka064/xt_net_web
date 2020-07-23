using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7
{
    class Program
    {
        static void Main(string[] args)
        {
            var motherShip = new MotherShip();

            Console.WriteLine("Please, write type of the spaceship:");
            var str = Console.ReadLine();

            var type = (SpaceShipType)Enum.Parse(typeof(SpaceShipType), str);

            var ship = motherShip.CreateSpaceShip(type);

            

            ship.Move();
        }

        #region OVERLOAD
        public static int Sum(int X, int Y) => X + Y;

        public static int Sum(int[] mass)
        {
            var res = 0;
            foreach (var item in mass)
                res += item;

            return res;
        }
        #endregion
    }

    public class BattleSquad
    {
        public IShootable[] ShootableShips { get; }

        public BattleSquad(IShootable[] _ships)
        {
            ShootableShips = _ships;
        }
    }

    public class MotherShip
    {
        public AbstractSpaceShip CreateSpaceShip(SpaceShipType type)
        {
            switch(type)
            {
                case SpaceShipType.LaserFighter:
                    return new LaserFighter(10);
                case SpaceShipType.MachineGunFighter:
                    return new MachineGunFighter(15);
                case SpaceShipType.TransportShip:
                    return new TransportShip();
                case SpaceShipType.Drone:
                    return new Drone(5);
                default: return null;
            }
        }

        public BattleSquad CreateSquad()
        {
            return new BattleSquad(new IShootable[]
            {
                new MachineGunFighter(15),
                new LaserFighter(10),
                new Drone(5)
            });
        }
    }

    public interface IMovable
    {
        void Move();
    }

    public interface IShootable
    {
        int Damage { get; }

        void Shoot();
    }

    public interface ISerializable
    {
        string Serialize();
    }

    public abstract class AbstractSpaceShip : IMovable, ISerializable
    {
        protected AbstractSpaceShip()
        {

        }

        public abstract void Move();

        public string Serialize() => " This is SpaceShip of type " + GetType();
    }

    public abstract class AbstractFighter : AbstractSpaceShip, IShootable
    {
        private int _damage;
        public virtual int Damage => _damage;

        protected AbstractFighter(int damage)
        {
            _damage = damage;
        }

        public sealed override void Move()
        {
            Console.WriteLine("Я ЛЕТАЮ И ИЩУ ВРАГОВ");
        }

        public abstract void Shoot();
    }

    public class LaserFighter : AbstractFighter
    {
        public LaserFighter(int damage) : base(damage)
        {
        }

        public override void Shoot()
        {
            Console.WriteLine("BZZZZ WITH DAMAGE: " + Damage);
        }
    }

    public class MachineGunFighter : AbstractFighter
    {
        public MachineGunFighter(int damage) : base(damage)
        {
        }

        public override void Shoot()
        {
            Console.WriteLine("TRA-TA-TA WITH DAMAGE: " + Damage);
        }
    }

    public class TransportShip : AbstractSpaceShip
    {
        public override void Move()
        {
            Console.WriteLine("Я МЕДЛЕННО ЛЕЧУ");
        }
    }

    public class Drone : AbstractSpaceShip, IShootable
    {
        private int _damage;
        public virtual int Damage => _damage;

        public Drone(int damage)
        {
            _damage = damage;
        }

        public override void Move()
        {
            Console.WriteLine("ЛЕЧУ С ЖУЖЖАНИЕМ");
        }

        public void Shoot()
        {
            Console.WriteLine("ПИУ-ПИУ with damage: " + Damage);
        }
    }

    public enum SpaceShipType
    {
        None,
        MachineGunFighter,
        TransportShip,
        LaserFighter,
        Drone
    }
}
