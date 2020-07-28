using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MyTest
{
    class Program
    {   
        // Ковариантность и контравариантность
        // Унас имеются два типа счета Account / DepositAccount
        //Первый тип Account
        class Account
        {
            public virtual void DoTransfer(int sum)
            {
                Console.WriteLine($"Клиент положил на счет {sum} долларов");
            }

          
        }

        // Второй тип DepositAccount унаследованный от Account
          class DepositAccount : Account
            {
                public override void DoTransfer(int sum)
                {
                    Console.WriteLine($"Клиент положил на депозитный счет {sum} долларов");
                }
            }

        // Ковариантный интерфейс
        interface IBank<out T>
        {
            T CreateAccount(int sum);
        }

        // Класс, использующий ковариантный интерфейс
        class Bank<T> : IBank<T> where T : Account, new()
        {
            public T CreateAccount(int sum)
            {
                T acc = new T(); // Создаем счет. На момент определения интерфейса мы не знаем, какой тип будет представлять счет.
                acc.DoTransfer(sum);
                return acc;
            }
        }
        static void Main(string[] args)
        {
            IBank<DepositAccount> depositBank = new Bank<DepositAccount>();


        }
    }

}