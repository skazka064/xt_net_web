using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTest
{
    class Program
    {

        static void Main(string[] args)
        {
            TestClass tt = new TestClass();
            Console.WriteLine(tt.GetMenu());
            IWindow iw = tt;
            Console.WriteLine(iw.GetMenu());
            IRestorant ir = tt;
            Console.WriteLine(ir.GetMenu());
            
        }
    }
    public interface IRestorant
    {
        object GetMenu();
    }

    public interface IWindow
    {
        object GetMenu();
    }

    public class TestClass : IWindow, IRestorant
    {
        public object GetMenu()
        {
            return "Собственный метод GetMenu";
        }

        object IWindow.GetMenu()
        {
            return "GetMenu интерфейса IWindow";
        }
        object IRestorant.GetMenu()
        {
            return "GetMenu интерфейса IRestorant";
        }
    }


  

}
