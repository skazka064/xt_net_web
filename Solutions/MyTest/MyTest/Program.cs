using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTest
{
    class Program
    {

        static void Main(string[] args)
        {
            
        }
    }
    
    public class SpaceShipFactory<T> where T : AbsrtactSpaceShip, new()
    {
        public T CreateShip()
        {
            return new T();
        }
    }

    public abstract class AbsrtactSpaceShip
    {

    }
    public abstract  class AbstractFighter: AbsrtactSpaceShip
    {

    }
    public class MachineGunFighter : AbsrtactSpaceShip
    {

    }
    public class MachineGunComander : MachineGunFighter
    {

    }
    public class Engineer: AbsrtactSpaceShip
    {

    }

    public interface IShipFactory<T>
    {
        T CreateShip();
    }

}
