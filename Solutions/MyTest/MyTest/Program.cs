using System;
using System.Collections;
using System.Collections.Generic;
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
  
    public abstract class AbstractSpaceshipFactory
    {
        public abstract AbstractSpaceShip CreateShip();
    }

    public class MashineGunShipFactory : AbstractSpaceshipFactory
    {
        public override AbstractSpaceShip CreateShip()
        {
            return new MachineGunFighter();
        }
    }

    public class EngineerFactory : AbstractSpaceshipFactory
    {
        public override AbstractSpaceShip CreateShip()
        {
            return new Engineer();
        }
    }

    public abstract  class AbstractSpaceShip
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

}
