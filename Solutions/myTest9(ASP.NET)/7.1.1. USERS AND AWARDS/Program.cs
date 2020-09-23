using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._1._1.USERS_AND_AWARDS
{
    class Program
    {

        public static string LocalDataPath => "Data\\";
        class User
        {
            public Guid ID{get; set;}
            public string Name { get; set; }
            public string DateOfBirth { get; set; }
            public  string Age { get; set; }
            protected User()
            {
                ID = Guid.NewGuid();
            }
            public User(string name, string dateofbirth,string age): this()
            {
                Name = name ?? throw new ArgumentNullException(nameof(name));
                DateOfBirth = dateofbirth ?? throw new ArgumentNullException(nameof(dateofbirth));
                Age = age ?? throw new ArgumentNullException(nameof(age));
            }

        }

        class Award
        {

        }



        static void Main(string[] args)
        {

        }
    }
}
