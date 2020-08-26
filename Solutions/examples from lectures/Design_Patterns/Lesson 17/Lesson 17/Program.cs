using Lesson_17.Abstract;
using Lesson_17.Humans;
using Lesson_17.Orcs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_17
{
    class Program
    {
        static void Main(string[] args)
        {
            var race = EnumInput<UnitRace>();

            var factory = AbstractFactory.CreateFactory(race);

            var type = EnumInput<UnitType>();

            AbstractUnit unit = factory.CreateUnit(type);

            var palad = new Paladin();

            unit.DealDamage();
        }

        public static T EnumInput<T>() where T : unmanaged
        {
            var userInput2 = Console.ReadLine();

            if (!Enum.TryParse(userInput2, out T type))
            {
                Console.WriteLine("Incorrect Input");
                return default(T);
            }

            return type;
        }
    }
}
