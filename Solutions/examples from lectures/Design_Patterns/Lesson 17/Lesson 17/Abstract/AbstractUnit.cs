using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_17.Abstract
{
    public abstract class AbstractUnit
    {
        public abstract void DealDamage();
    }

    public enum UnitType
    {
        None,
        Melee,
        Range  
    }

    public enum UnitRace
    {
        None,
        Orc,
        Human,
        Elf
    }
}
