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
    public class JsonRewardDAL : IRewardDAL
    {
        public static string LocalDataPath => "Data\\Rewards\\";

        public IEnumerable<Reward> GetAllRewards()
        {
            throw new NotImplementedException();
        }

        public void SaveReward(Reward reward)
        {

            if (reward == null) throw new ArgumentNullException(nameof(reward));
            DirectoryInfo dirInfo = new DirectoryInfo(LocalDataPath);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }
            string fileName = "Reward_" + reward.User.ID + ".json";

         
        }
    }
}
