using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory<Item> inventoryItem = new Inventory<Item>(new Item[] { });
            Inventory<Book> inventoryBook = new Inventory<Book>(new Book[] { });
            Inventory<Ork> inventoryOrk = new Inventory<Ork>(new Ork[] {new Ork(), new Ork() });
            Inventory inventory = new Inventory();

            Inventory<Item>.A= 10;
            Console.WriteLine(Inventory<Item>.A);
            Console.WriteLine(Inventory<Book>.A);
        }
    }
    public class Inventory<T> : IEnumerable
    {
        public static int A=5;
        public T[] Items { get; private set; }
        public Inventory(T[] items)
        {
            Items = items;
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
    public class Inventory
    {

    }

    public class Item
    {

    }

    public class Book
    {

    }

    public class Ork 
    {
        
    }

}
