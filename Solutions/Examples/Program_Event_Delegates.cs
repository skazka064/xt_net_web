using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Lesson_11
{
    class Program
    {
        static void Main(string[] args)
        {
            MotherShip baseShip = new MotherShip();

            var fighter1 = baseShip.CreateShip(ShipType.Fighter);
            var fighter2 = baseShip.CreateShip(ShipType.Fighter);
            var engineer1 = baseShip.CreateShip(ShipType.Engineer);

            foreach (var item in baseShip.Ships)
            {
                Console.WriteLine(item);
            }

            fighter1.Damage(10);
            fighter2.Damage(100);
            engineer1.Damage(50);

            Console.WriteLine();

            foreach (var item in baseShip.Ships)
            {
                Console.WriteLine(item);
            }
        }

        #region APPLY_TO_MASS

        static void ApplyToMass<T>(T[] mass, Func<T, T> function)
        {
            if (function == null)
                return;

            for (int i = 0; i < mass.Length; i++)
                mass[i] = function.Invoke(mass[i]);
        }

        #endregion
    }

    public class MotherShip
    {
        public List<AbstractSpaceShip> Ships { get; set; }

        public MotherShip()
        {
            Ships = new List<AbstractSpaceShip>();
        }

        public AbstractSpaceShip CreateShip(ShipType type)
        {
            AbstractSpaceShip ship; 

            switch (type)
            {
                case ShipType.Fighter: ship = new Fighter(); break;
                case ShipType.Engineer: ship = new Engineer(); break;
                default: throw new ArgumentException("Unknown spaceship type", "type");
            }

            Ships.Add(ship);

            ship.OnDestroy += RemoveShip;

            return ship;
        }

        public void RemoveShip(AbstractSpaceShip ship)
        {
            Ships.Remove(ship);

            ship.OnDestroy -= RemoveShip;
        }
    }

    public abstract class AbstractSpaceShip
    {
        public event Action<AbstractSpaceShip> OnDestroy = delegate { };

        public int MaxHP { get; } = 100;

        private int hp;
        public int HP 
        {
            get => hp;
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

        public void Damage(int damage)
        {
            HP -= damage;
        }

        private void Destroy()
        {
            OnDestroy?.Invoke(this);
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

    #region DOWNLOADER

    public class Downloader
    {
        public void Download(string url, Action<File> handler)
        {
            // TODO: downloading

            handler(new File());
        }
    }

    public class File
    {

    }

    #endregion
}
