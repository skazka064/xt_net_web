using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleLectionAsyncAndLazy
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Loader
    {
        public UserData[] LoadData()
        {
            // Подключаемся к базе
            // Получение данных с БД
            return new UserData[]
            {
                new UserData(){Name = "Anton", Id = Guid.NewGuid(), Files = new File[]{ } },
                new UserData(){Name = "Sergio", Id = Guid.NewGuid(), Files = new File[]{ }},
                new UserData(){Name = "Pet", Id = Guid.NewGuid(), Files = new File[]{ }},

            };
        }

        public IEnumerable LoadDataOptimized()
        {
            var database = new UserData[]{
                new UserData(){Name = "Anton", Id = Guid.NewGuid(), Files = new File[]{ } },
                new UserData(){Name = "Sergio", Id = Guid.NewGuid(), Files = new File[]{ }},
                new UserData(){Name = "Pet", Id = Guid.NewGuid(), Files = new File[]{ }},

            };

            foreach (var item in database)
            {
                //  TODO: вытягивание данных с Базы данных
                yield return item;
            }

           
        }


    }

    public class UserData
    {
        public string Name { get; set; }
        public Guid Id { get; set; }
        public IEnumerable<File> Files { get; set; }
       
    }

    public class File
    {

    }
}
