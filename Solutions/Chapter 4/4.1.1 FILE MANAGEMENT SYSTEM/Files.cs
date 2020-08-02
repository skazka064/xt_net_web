using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1._1_FILE_MANAGEMENT_SYSTEM
{
    class Files
    {
        public string Name { get; set; }
        public string FileContents { get; set; }

        public Files(string name, string fileContents)
        {
            Name = name;
            FileContents = fileContents;
        }
    }
}
