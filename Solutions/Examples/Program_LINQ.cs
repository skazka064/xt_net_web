using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_12
{
    class Program
    {
        static void Main(string[] args)
        {
            var playerShip = new Fighter() { Name = "Aurora", Damage = 100500, Age = 99 };

            var ships = new AbstractSpaceShip[] 
            {
                playerShip,
                new Fighter() { Name = "Hunter ver.1", Damage = 500, Age = 15 },
                new Fighter() { Name = "Nova", Damage = 150, Age = 1},
                new Engineer() { Name = "Buffalo", Damage = 7000, Age = 5},
                new Fighter() { Name = "Tiger", Damage = 3500, Age = 3}
            };

            var ships2 = new AbstractSpaceShip[]
            {
                playerShip,
                new Fighter() { Name = "Butterfly", Damage = 100, Age = 2},
                new Fighter() { Name = "Bug", Damage = 500, Age = 3 }
            };

            var ships3 = new int[] { };

            #region EXAMPLES

            // Where - отбор елементов по переданному условию - только корабли, которым 5 лет и меньше
            var res = ships.Where(e => e.Age <= 5);

            // Count - подсчет количества элементов IEnumerable<T>
            var res2 = ships.Where(e => e.Age <= 5).Count();

            // Select - проекция одной сущности на другую
            var res3 = ships.Select(e => new { e.Name, e.Damage });

            // OfType - выборка по типу
            var res4 = ships.OfType<Fighter>();

            // Union - объединение коллекций
            var res5 = ships.Union(ships2);

            // Intersect - пересечение коллекций
            var res6 = ships.Intersect(ships2);

            // Except - исключение из первой коллекции элементов, присутствующих во второй коллекции
            var res7 = ships.Except(ships2);

            // First - первый элемент последовательности
            var res8 = ships.First();

            // Last - последний элемент последовательности
            var res9 = ships.Last();

            // FirstOrDefault - первый элемент последовательности, default(T) для типа в случае пустой коллекции
            var res10 = ships.FirstOrDefault();

            // LastOrDefault - последний элемент последовательности, default(T) для типа в случае пустой коллекции
            var res11 = ships.LastOrDefault();

            // Max, Min - максимальне / минимальное значение аттрибута элемента коллекции
            var res12 = ships.Max(s => s.Age);

            // пример выбора ЭЛЕМЕНТА с максимальным значением аттрибута
            var res13 = ships.OrderBy(s => s.Age).LastOrDefault();

            // проверка соответствия хоть одного элемента переданному условию
            var res14 = ships.Any(e => e.Damage > 10000);

            // проверка коллекции на непустоту
            var res15 = ships.Any();

            // приведение результата из IEnumerable к листу - аггрегирует результат из отложенного в реальный
            var res16 = ships.ToList();

            #endregion
        }

    }

    public abstract class AbstractSpaceShip
    {
        public string Name { get; set; }

        public int Damage { get; set; }

        public int Age { get; set; }
    }

    public class Fighter : AbstractSpaceShip
    {

    }

    public class Engineer : AbstractSpaceShip
    {

    }
}
