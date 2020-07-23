using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_9_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            // SpaceShipFactory<MachineGunFighter> factory = new SpaceShipFactory<MachineGunFighter>();

            // var ship = factory.CreateShip();

            IShipFactory<AbstractSpaceShip> factory = new MachineGunFighterFactory();

            IShipDestroyer<MachineGunCommander> destroyer = new MachineGunFighterDestroyer();
        }

    }

    public interface IShipFactory<out T>
    {
        T CreateShip();
    }

    public interface IShipDestroyer<in T>
    {
        void DestroyShip(T ship);
    }

    public class MachineGunFighterDestroyer : IShipDestroyer<MachineGunFighter>
    {
        public void DestroyShip(MachineGunFighter ship)
        {
            // TO DO
        }
    }

    public class MachineGunFighterFactory : IShipFactory<MachineGunFighter>
    {
        public MachineGunFighter CreateShip()
        {
            return new MachineGunFighter();
        }
    }

    //public class SpaceShipFactory<T> where T : AbstractSpaceShip, new()
    //{
    //    public T CreateShip()
    //    {
    //        return new T();
    //    }
    //}

    public abstract class AbstractSpaceShip
    {

    }

    public abstract class AbstractFighter : AbstractSpaceShip
    {

    }

    public class Engineer : AbstractSpaceShip
    {

    }

    public class MachineGunFighter : AbstractFighter
    {

    }

    public class MachineGunCommander : MachineGunFighter
    {

    }
}
