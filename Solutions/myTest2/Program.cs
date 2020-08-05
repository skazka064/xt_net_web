using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace myTest2
{    
    
    class Program
    {
       
        static void Main(string[] args)
        {
            
        }
        
    }
    public class Loader
    {
        public UserData[] LoadData()
        {
            //todo connect to database
            //todo getting data from database

            return new UserData[]
            {
                new UserData (){Name = "Anton" , Id =Guid.NewGuid(),Files = new File []{ } },
                new UserData (){Name = "Vasya" , Id =Guid.NewGuid(),Files = new File []{ }},
                new UserData (){Name = "Petya" , Id =Guid.NewGuid(),Files  = new File []{ }}
            };
        }
    }

    public class UserData
    {
        public string Name { get; set; }
        public  Guid Id { get; set; }
        public IEnumerable<File> Files { get; set; }
       

    }
    public class File
    {
        //TODO
    }
}
