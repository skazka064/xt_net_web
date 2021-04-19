using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleLectionFile
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(var item in DriveInfo.GetDrives())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(Environment.SystemDirectory);
            var f = DriveInfo.GetDrives().FirstOrDefault(dr => dr.Name.StartsWith("C"));
            Console.WriteLine(f);
            Console.WriteLine($"Size: {f.TotalSize}, Current : {f.TotalSize - f.TotalFreeSpace}" );
            Console.WriteLine($"Label: {f.VolumeLabel}");
            var sample = new DirectoryInfo(@"c:/Distrib");
            var file = new FileSystemWatcher(@"c:/Distrib");
            var stream = new FileStream(@"c:/distrib/111.txt", FileMode.OpenOrCreate);
            var reader = new StreamReader(stream);
            Console.WriteLine(reader.ReadToEnd());
            var str= "\nHello World!";
            var writer = new StreamWriter(stream);
            writer.WriteLine(str);
            writer.Close();
            stream.Close();
           foreach(var item in sample.GetFiles())
            {
                Console.WriteLine(item);
            }
            var stream2 = new FileStream(@"c:/distrib/111.txt", FileMode.OpenOrCreate);
            using (var reader2 = new StreamReader(stream2))
            {
                Console.WriteLine(reader2.ReadToEnd());
            }
            string[] args2 = System.Environment.GetCommandLineArgs();
            Console.WriteLine(args2.Length);
            foreach(var item in args2)
            {
                Console.WriteLine(item);
            }
            FileSystemWatcher watcher = new FileSystemWatcher();
        }
    }
}
