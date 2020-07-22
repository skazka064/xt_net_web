using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_14
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var stream = new MyValue())
            {

            }
        }

        /// <summary>
        /// Getting integer value from file with path 'filePath'
        /// </summary>
        static int GetValueFromBinaryFile(string filePath)
        {
            var file = new FileInfo(filePath);

            if (!file.Exists)
                throw new FileNotFoundException("File Not Found");

            var stream = new FileStream(filePath, FileMode.Open);

            var byteArr = new byte[stream.Length];

            for (int i = 0; i < byteArr.Length; i++)
                byteArr[i] = (byte)stream.ReadByte();

            stream.Close();

            return BitConverter.ToInt32(byteArr, 0);
        }

        /// <summary>
        /// Writing value as byte array in the file with location 'filePath'
        /// </summary>
        static void WriteBytesFromIntValue(int value, string filePath)
        {
            var file = new FileInfo(filePath);

            if (!file.Exists)
                throw new FileNotFoundException("File Not Found");

            var stream = new FileStream(filePath, FileMode.Open);

            var bytes = BitConverter.GetBytes(value);

            stream.Write(bytes, 0, bytes.Length);

            stream.Close();
        }

        static void DirectoriesExample()
        {
            var driveF = DriveInfo.GetDrives().FirstOrDefault(dr => dr.Name.StartsWith("F"));

            if (driveF == null)
                return;

            Console.WriteLine($"Size: {driveF.TotalSize}, Current: {driveF.TotalSize - driveF.AvailableFreeSpace}");
            Console.WriteLine($"Label: {driveF.VolumeLabel}");
            Console.WriteLine();

            var directories = driveF.RootDirectory.EnumerateDirectories();

            foreach (var directory in directories)
            {
                Console.WriteLine($"{directory.Attributes} \t {directory.Name} \t {directory.FullName}");
            }
        }

    }

    class MyStream : IDisposable
    {
        public void Dispose()
        {
            // TO DO: Dispose all resources
            Console.WriteLine("Привет с того берега!");
        }
    }

    struct MyValue : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("BLA BLA");
        }
    }
}
