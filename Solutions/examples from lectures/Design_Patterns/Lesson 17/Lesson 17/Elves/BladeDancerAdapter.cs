using Lesson_17.Abstract;
using Lesson_17.ElvesDLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_17.Elves
{
    public class BladeDancerAdapter : MeleeUnit
    {
        private BladeDancer _internal = null;

        public override void DealDamage()
        {
            _internal.SingSong();
            _internal.PrepareSword();
            _internal.Hit();
        }

        public BladeDancerAdapter(BladeDancer bladeDancer)
        {
            _internal = bladeDancer;
        }
    }
}
