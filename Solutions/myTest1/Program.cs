using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myTest1
{
    class Program
    {
        static void Main(string[] args)
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                Console.WriteLine("Имя: {0} ", drive.Name);
                Console.WriteLine("Тип: {0}", drive.DriveType);
                Console.WriteLine("Готовность: {0}", drive.IsReady);
            }
        }
    }
}
