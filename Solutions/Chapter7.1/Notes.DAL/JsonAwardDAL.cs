using Newtonsoft.Json;
using Notes.DAL.Common;
using Notes.Entites;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.DAL
{
   public class JsonAwardDAL : IAwardDAL
    {
        public static string LocalDataPath => "Data\\Awards\\";
        public void DeleteAward(Guid id)
        {
            string awardString = LocalDataPath + "Award_" + id + ".json";
            File.Delete(awardString);
        }

        public IEnumerable<Award> GetAllAwards()
        {
            var directory = new DirectoryInfo(Environment.CurrentDirectory + "\\" + LocalDataPath);
            foreach (var file in directory.GetFiles())
                using (var reader = new StreamReader(file.FullName))
                    yield return JsonConvert.DeserializeObject<Award>(reader.ReadToEnd());
        }

        public Award GetAwardByID(Guid id)
        {
            return GetAllAwards().FirstOrDefault(n => n.ID == id);
        }

        public void SaveAward(Award award)
        {
            if (award == null)

                throw new ArgumentNullException(nameof(award));
            var awardName = "Award_" + award.ID + ".json";
            var awardStr = JsonConvert.SerializeObject(award);
            using (var writer = new StreamWriter(LocalDataPath + awardName))
                writer.Write(awardStr);
        }
    }
}
