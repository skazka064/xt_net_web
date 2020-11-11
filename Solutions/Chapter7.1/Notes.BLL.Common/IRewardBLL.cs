using Notes.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.BLL.Common
{
    public interface IRewardBLL
    {
        bool RewardUser(Guid userID, Guid awardID);
        IEnumerable<Reward> GetAllRewards();
    }
}
