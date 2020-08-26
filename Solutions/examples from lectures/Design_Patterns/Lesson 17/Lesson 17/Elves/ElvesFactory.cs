using Lesson_17.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_17.Elves
{
    public class ElvesFactory : AbstractFactory
    {
        private ElvesFactory() { }

        private static ElvesFactory _instance;
        public static ElvesFactory Instance => _instance ?? (_instance = new ElvesFactory());

        public override AbstractUnit CreateUnit(UnitType type)
        {
            switch (type)
            {
                case UnitType.Melee:
                    return CreateBladeDancer();
                case UnitType.Range:
                    return CreateElfMage();
                default: throw new ArgumentException("Incorrect Unit Type", "type");
            }
        }

        private BladeDancerAdapter CreateBladeDancer() => new BladeDancerAdapter(new ElvesDLL.BladeDancer());

        private ElfMageAdapter CreateElfMage() => new ElfMageAdapter(new ElvesDLL.ElfMage());
    }
}
