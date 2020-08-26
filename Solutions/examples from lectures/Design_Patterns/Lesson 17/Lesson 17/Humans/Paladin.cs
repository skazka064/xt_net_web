using Lesson_17.Abstract;

namespace Lesson_17.Humans
{
    public class Paladin : MeleeUnit
    {
        public override void DealDamage()
        {
            SwordHit();
        }

        private void SwordHit()
        {
            System.Console.WriteLine("Получай, скверна!");
        }
    }
}
