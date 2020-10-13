using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._1._1.USERS_AND_AWARDS
{
    static  class Tools
    {
  public static string LocalDataPath => "Data\\";
       public  static IEnumerable<User> GetAllUser()
        {
            var directory = new DirectoryInfo(Environment.CurrentDirectory + "\\" +  LocalDataPath);
            foreach (var file in directory.GetFiles())
                using (var reader = new StreamReader(file.FullName))
                    yield return JsonConvert.DeserializeObject<User>(reader.ReadToEnd());
        }
        public static void SaveUser(User user)
        {
            if (user == null)
            
                throw new ArgumentNullException(nameof(user));
            var userName = "User_" + user.ID + ".json";
            var userStr = JsonConvert.SerializeObject(user);
            using (var writer = new StreamWriter(LocalDataPath + userName))
                writer.Write(userStr);
            
            
        }
    }
    class Program
    {
       
        static void Main(string[] args)
        {
           
            //var user = new User("Ivan", "26.07.2000", "20");
            //SaveUser(user);
            var user = Tools.GetAllUser().ToList();
            Console.WriteLine(user);
            Console.ReadKey();

        }
    }

    class User
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string DateOfBirth { get; set; }
        public string Age { get; set; }
        protected User()
        {
            ID = Guid.NewGuid();
        }
        public User(string name, string dateofbirth, string age) : this()
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            DateOfBirth = dateofbirth ?? throw new ArgumentNullException(nameof(dateofbirth));
            Age = age ?? throw new ArgumentNullException(nameof(age));
        }

         
    }
    

    
}
