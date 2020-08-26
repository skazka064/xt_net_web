using Lesson_17.Abstract;

namespace Lesson_17.Orcs
{
    public class Shaman : RangeUnit
    {
        public override void DealDamage()
        {
            SpellCast();
        }

        private void SpellCast()
        {
            System.Console.WriteLine("О-м-м-м-м-м-м...");
        }
    }
}
