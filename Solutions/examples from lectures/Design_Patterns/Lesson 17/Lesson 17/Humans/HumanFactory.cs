using Lesson_17.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_17.Humans
{
    public class HumanFactory : AbstractFactory
    {
        private HumanFactory() { }

        private static HumanFactory _instance;
        public static HumanFactory Instance => _instance ?? (_instance = new HumanFactory());

        public override AbstractUnit CreateUnit(UnitType type)
        {
            switch(type)
            {
                case UnitType.Melee:
                    return CreatePaladin();
                case UnitType.Range:
                    return CreateArcher();
                default: throw new ArgumentException("Incorrect Unit Type", "type");
            }
        }

        private Paladin CreatePaladin() => new Paladin();

        private Archer CreateArcher() => new Archer();

        
    }
}
