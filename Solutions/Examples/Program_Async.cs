using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson_15
{
    class Program
    {
        public static async Task<int> StartAnimation(Animations type)
        {
            Console.WriteLine("Starting Animation: " + type);

            var task = new Task(() =>
            {
                switch (type)
                {
                    case Animations.Idle: break;
                    case Animations.Jump: break;
                    case Animations.Run: break;
                }
            });

            task.Wait(TimeSpan.FromSeconds(5));
            task.Start();

            Console.WriteLine("Animation " + type + " has completed!");

            await task;
            return 5;
        }


        public enum Animations
        {
            Idle,
            Jump,
            Run
        }


        private static object _locker = new object();
        public static void StepByStep()
        {
            lock (_locker)
            {
                var count = 0;
                for (int i = 0; i < 10; i++)
                {
                    count++;
                    Console.WriteLine("In the thread: " + Thread.CurrentThread.Name
                         + " value of count = " + count);
                    Thread.Sleep(TimeSpan.FromSeconds(1));
                }
            }
        }
        public static void Main(string[] args)
        {
            Thread th = new Thread(StepByStep);
            th.Name = "Thread 1";
            th.Start();
            Thread th2 = new Thread(StepByStep);
            th2.Name = "Thread 2";
            th2.Start();
        }


    }

    public class Loader
    {
        public UserData[] LoadData()
        {
            // TODO: connect to database

            // TODO: getting data from database

            return new UserData[]
            {
                new UserData() { Name = "Anton", Id = Guid.NewGuid(), Files = new File[] { } },
                new UserData() { Name = "Vasya", Id = Guid.NewGuid(), Files = new File[] { } },
                new UserData() { Name = "Petya", Id = Guid.NewGuid(), Files = new File[] { } }
            };
        }

        public IEnumerable<UserData> LoadDataOptimized()
        {

            var database = new UserData[]
            {
                new UserData() { Name = "Anton", Id = Guid.NewGuid(), Files = new File[] { } },
                new UserData() { Name = "Vasya", Id = Guid.NewGuid(), Files = new File[] { } },
                new UserData() { Name = "Petya", Id = Guid.NewGuid(), Files = new File[] { } },
                null,
                null,
                null
            };

            foreach (var item in database)
            {
                if (item == null)
                    yield break;

                // TODO: getting data from database
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
        // TODO
    }
}
