using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files_and_Streams
{
    class Program
    {
        static void DirectotiesExample()
            {
              var driveF = DriveInfo.GetDrives().FirstOrDefault(dr => dr.Name.StartsWith("C"));
              if (driveF == null) return;
            Console.WriteLine($"Size: {driveF.TotalSize}, Current: {driveF.TotalSize-driveF.AvailableFreeSpace}");
            Console.WriteLine($"Label: {driveF.VolumeLabel}");
            Console.WriteLine();
            var directories = driveF.RootDirectory.EnumerateDirectories();
            foreach(var directory in directories)
            {
                Console.WriteLine($"{directory.Attributes} \t {directory.Name} \t {directory.FullName}");
            }
            }
        static void Main(string[] args)
        {
            FileInfo fileInfo = new FileInfo("C:/distrib/myJson.txt");
            Console.WriteLine(fileInfo.CreationTime);
            fileInfo.CreationTime = DateTime.Now.Add(TimeSpan.FromDays(5));
            Console.WriteLine(fileInfo.CreationTime);

            // File.Create(@"C:/distrib/myJson2.txt");
            //  DirectoryInfo directoryInfo = new DirectoryInfo();
            var stream = new FileStream(@"C:/distrib/myJson2.txt" ,FileMode.OpenOrCreate);


            
        }
    }  
}
