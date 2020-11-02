using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Notes.Entites;
using System.Linq;
using Notes.DAL.Common;

namespace Notes.DAL
{
    
    public class JsonNotesDAO : INotesDAL
    {
        
        public static string LocalDataPath => "Data\\";

       
               
        public IEnumerable<User> GetAllUser()
        {
            var directory = new DirectoryInfo(Environment.CurrentDirectory + "\\" + LocalDataPath);
            foreach (var file in directory.GetFiles())
                using (var reader = new StreamReader(file.FullName))
                    yield return JsonConvert.DeserializeObject<User>(reader.ReadToEnd());
        }


        User INotesDAL.GetNoteByID(Guid id)
        {
            return GetAllUser().FirstOrDefault(n => n.ID == id);
        }
        public User  GetUserByID(Guid id) => GetAllUser().FirstOrDefault(n => n.ID == id);

    
        public void SaveUser(User user)
        {
            if (user == null)

                throw new ArgumentNullException(nameof(user));
            var userName = "User_" + user.ID + ".json";
            var userStr = JsonConvert.SerializeObject(user);
            using (var writer = new StreamWriter(LocalDataPath + userName))
                writer.Write(userStr);
        }

        
    }
}
