using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleLectionExtensionAndLONQ
{
    class Program
    {       
       
        int[] GetPositive(int[] array)
        {
            var list = new List<int>();
            foreach (var item in array)
            {
                if (item > 0)
                {
                    list.Add(item);
                }
             }
            return list.ToArray();
        }
        int[] GetPositiveLINQ(int[] array)
        {
            var query = from item in array
                        where item > 0
                        select item;
            return query.ToArray();

        }
        int []GetPositiveLINQAnon(int[] array)
        {
            var query = array.Where(item => item > 10);
            return query.ToArray();
        }
        static void Main(string[] args)
        {
          



            int[] mass = new int[] { 1, -2, 3, 4, 5, 6, 12 };

           var result =  mass.Average2();

            var obj = new
            {
                Name = "Sergey",
                Value = 15
            };
            var obj2 = new Program();
            int[] arr= obj2.GetPositiveLINQ(mass);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            var playerShip = new Fighter() { Name = "Aurora", Damage = 100500, Age = 99 };

            var ships = new AbstractSpaceShip[]
            {
                playerShip,
                new Fighter() {Name = "Hunter ver.1", Damage =500, Age = 15},
                new Fighter() {Name = "Nova", Damage =100, Age = 1},
                 new Engineer() {Name = "Buffalo", Damage =7000, Age = 3},
                  new Fighter() {Name = "Tiget", Damage =3500, Age = 5}
            };

            var ships2 = new AbstractSpaceShip[]
           {
               playerShip,
                new Fighter() {Name = "Butterfly", Damage =100, Age = 3},
                new Fighter() {Name = "bug", Damage =500, Age = 2},
               
           };




            var res = from item in ships
                      where item.Damage == 100
                      select new
                      {
                          item.Name,
                          item.Damage,


                      };
                     

            var res1 = ships.Where(item => item.Name == "Aurora");
            var res2 = ships.Select(item => item.Name);
           
            foreach(var item in res1)
            {
                Console.WriteLine(item);
            }

#region EXAMPLES 
            // Where отбор элементов по переданному условию , только корабли, которым 5 лет и меньше
            var res3 = ships.Where(e => e.Age <= 5);

            // Count подсчет количества элементов IEnumerable<T>
            var res4 = ships.Where(e => e.Age <= 5).Count(); 

            // Select - проекция одной сущности в другую
            var res5 = ships.Select(e => new { e.Name, e.Damage });
           
            // OfType выборка по типу
            var res6 = ships.OfType<Fighter>();

            foreach (var item in res6)
            {
                Console.WriteLine(new {item.Name,item.Damage, item.Age  });
            }

            // Union - объединение коллекций
            var res7 = ships.Union(ships2);
            foreach (var item in res7)
            {
                Console.WriteLine(item.Name);
               
            }   
            
            // Intersect -  пересечение коллекций
            var res8 = ships.Intersect(ships2);
            foreach (var item in res8)
            {
                
                Console.WriteLine(item.Name + " - Пересечение");
            }

            // Except - исключение из первой коллекции элементов, присутствующих во второй коллекции
            var res9 = ships.Except(ships2);
            foreach (var item in res9)
            {

                Console.WriteLine(item.Name+" - Разность");
            }

            //First - первый элемент последовательности
            var res10 = ships.First();
            
            //Last - последний элемент последовательности
            var res11 = ships.Last();

            //FirstOrDefault - первый элемент последовательности , default(T) для типа в случае пустой коллекции
            var res12 = ships.FirstOrDefault();

            //LastOrDefault - последний элемент последовательности
            var res13 = ships.LastOrDefault();

            // Max, Min - максимальное/ минимальное значение атрибута коллекции
            var res14 = ships.Where(s=>s.Damage == ships.Min(e=>e.Damage));
         
            foreach (var item in res14)
            {
                Console.WriteLine("Ship whith Min Damage: {0}", item.Name);
            }

            var res15 = ships.Where(s => s.Damage == ships.Max(e => e.Damage));
           
            foreach (var item in res15)
            {
                Console.WriteLine("Ship whith Max Damage: {0}", item.Name);
            }

            // пример выбора элемента с максимальным значением элемента
            var res16 = ships.OrderBy(s => s.Age).LastOrDefault();

            // проверка соответствия хоть одного элемента переданному условию
            var res17 = ships.Any(e => e.Damage > 1000);
            Console.WriteLine(res17);

            // проверка коллекции на непустоту
            var res18 = ships.Any();
            Console.WriteLine(res18);
            #endregion

            var count = ships.Count(e=>e.Age>5);
            ships[2].Age = 15;

            Console.WriteLine("Count - {0}",count);

            // Формируем источники данных для JOIN
            var groups = new List<Group>
            {
                new Group{GroupId =1, Name = "Начальный уровень"},
                 new Group{GroupId =2, Name = "Базовый уровень"},
                  new Group{GroupId =3, Name = "Продвинутый уровень"},
                  new Group{GroupId =5, Name = "Супер"},
            };

            var students = new List<Students>
            {
                new Students{Name = "Ivanov" , GroupId=1},
                new Students{Name = "Petrov" , GroupId=2},
                new Students{Name = "Sidorov" , GroupId=3},
                new Students{Name = "Smirnov" , GroupId=1},
                new Students{Name = "Tkachev" , GroupId=1},
                new Students{Name = "Nikolaev" , GroupId=2},
                new Students{Name = "Tokarev" , GroupId=1},
                new Students{Name = "Berezin" , GroupId=3},
                new Students{Name = "Oganiesian" , GroupId=4},
                new Students{Name = "Iv" , GroupId=1},
            };

            //inner join 
            var query2 = from st in students
                         join gr in groups
                         on st.GroupId equals gr.GroupId
                         select new
                         {
                             s= st.Name,
                             g= gr.Name
                         };
            foreach (var item in query2)
            {
                Console.WriteLine("{0} - {1}", item.s, item.g);
            }

            var query3 = from st in students
                         join gr in groups
                         on st.GroupId equals gr.GroupId
                         group gr by gr.GroupId into g
                         select new
                         {
                             NameGroup = g.Key
                         };

            Console.WriteLine("#####################");
            
            foreach (var group in query3)
            {
                Console.WriteLine(group.NameGroup);
                
            }
           
            Console.WriteLine("#####################");

       var query = from item in students
                        group item by item.GroupId;

            foreach (var group in query)
            {
                Console.WriteLine(group.Key);
                foreach (var item in group)
                {
                    Console.WriteLine(item.Name );
                }
            }
        }

        
    }

    public static class Int32ArrayExtensions
    {
     
        public static int Average2(this int[] mass)
        {
            if (mass == null || mass.Length == 0)
                throw new ArgumentException("'mass' argument cannot be null or empty");
            var sum = 0;
            foreach (var item in mass)
            {
                sum += item;
                
            }
            return sum / mass.Length;
        }
        public static void Modify(this int[] mass, Func<int,int> modification)
        {
           if(mass==null || mass.Length==null)
            {
                throw new ArgumentException("'mass' argument cannot be null or empty");
            }
            var sum = 0;

            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = modification(mass[i]);

            }
        }

    }

    public class AbstractSpaceShip
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
    class Students
    {
        public string Name { get; set; }
        public int GroupId { get; set; }
    }

    class Group
    {
        public string Name { get; set; }
        public int GroupId { get; set; }
    }

}
