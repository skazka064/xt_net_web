using Lesson_17.Abstract;
using Lesson_17.ElvesDLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_17.Elves
{
    public class ElfMageAdapter : RangeUnit
    {
        private ElfMage _internal = null;

        public override void DealDamage()
        {
            _internal.CastSpell();
        }

        public ElfMageAdapter(ElfMage mage)
        {
            _internal = mage;
        }
    }
}
