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
  
    public  class SpaceshipFactory<T> where T:new()
    { 
        public  T CreateShip()
        {
            return new T();
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
