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
                Console.WriteLine("���: {0} ", drive.Name);
                Console.WriteLine("���: {0}", drive.DriveType);
                Console.WriteLine("����������: {0}", drive.IsReady);
            }
        }
    }
}
