using Lesson_17.Elves;
using Lesson_17.Humans;
using Lesson_17.Orcs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_17.Abstract
{
    public abstract class AbstractFactory
    {
        public abstract AbstractUnit CreateUnit(UnitType type);

        public static AbstractFactory CreateFactory(UnitRace race)
        {
            switch(race)
            {
                case UnitRace.Human:
                    return HumanFactory.Instance;
                case UnitRace.Orc:
                    return OrcFactory.Instance;
                case UnitRace.Elf:
                    return ElvesFactory.Instance;
                default: throw new ArgumentException("Incorrect Unit Race", "race");
            }
        }
    }
}
