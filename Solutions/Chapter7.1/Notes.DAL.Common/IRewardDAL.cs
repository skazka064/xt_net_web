using Notes.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.DAL.Common
{
    public interface IRewardDAL
    {
        void SaveReward(Reward reward);
        IEnumerable<Reward> GetAllRewards();
    }
}
