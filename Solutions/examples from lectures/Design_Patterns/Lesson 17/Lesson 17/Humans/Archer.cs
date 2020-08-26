using Lesson_17.Abstract;

namespace Lesson_17.Humans
{
    public class Archer : RangeUnit
    {
        public override void DealDamage()
        {
            Shoot();
        }

        private void Shoot()
        {
            System.Console.WriteLine("Попробуй догони!");
        }
    }
}
