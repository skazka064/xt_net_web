using Notes.BLL.Common;
using Notes.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.BLL
{
    public class RewardBLL : IRewardBLL
    {
        public IEnumerable<Reward> GetAllRewards()
        {
            throw new NotImplementedException();
        }

        public bool RewardUser(Guid userID, Guid awardID)
        {
            throw new NotImplementedException();
        }
    }
}
