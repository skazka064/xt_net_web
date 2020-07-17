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

        static void Main(string[] args)
        {
            string path=  Console.ReadLine();
            FileManager fm = new FileManager();
             
            Console.WriteLine(fm.GetContent(path));
        }
    }
    
    public class FileManager
    {
        private readonly Encoding _defaultEncoding = Encoding.GetEncoding(1251);
        
        public string GetContent(string filePath)
        {
            return GetContent(filePath, _defaultEncoding);
        }

        public string GetContent( string filePath, Encoding encoding)
        {
            string content = File.ReadAllText(filePath, encoding);
            return content;
        }


    }
    

}
