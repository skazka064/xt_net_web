using Lesson_17.Abstract;

namespace Lesson_17.Orcs
{
    public class Berserk : MeleeUnit
    {
        public override void DealDamage()
        {
            AxeHit();
        }

        private void AxeHit()
        {
            System.Console.WriteLine("АГРХ!");
        }
    }
}
