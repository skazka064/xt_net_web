using Lesson_17.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_17.Orcs
{
    public class OrcFactory : AbstractFactory
    {
        private OrcFactory() { }

        private static OrcFactory _instance;
        public static OrcFactory Instance => _instance ?? (_instance = new OrcFactory());

        public override AbstractUnit CreateUnit(UnitType type)
        {
            switch (type)
            {
                case UnitType.Melee:
                    return CreatePaladin();
                case UnitType.Range:
                    return CreateArcher();
                default: throw new ArgumentException("Incorrect Unit Type", "type");
            }
        }

        private Berserk CreatePaladin() => new Berserk();

        private Shaman CreateArcher() => new Shaman();
    }
}
