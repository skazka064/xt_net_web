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
    class Program
    {
        public static string LocalDataPath => "Data\\";
        public static IEnumerable<User> GetAllUser()
        {
            var directory = new DirectoryInfo(Environment.CurrentDirectory + "\\" + "Data");
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
        static void Main(string[] args)
        {
            var user1 = new User("Sergio", "26.07.1976", "44");
            SaveUser(user1);

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
