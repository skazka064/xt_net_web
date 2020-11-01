using Notes.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.BLL.Common
{
    public interface IAwardBLL
    {
        bool SaveAward(Award award);
        bool DeleteAward(Guid id);
        IEnumerable<Award> GetAllAwards();
        Award GetAwardByID(Guid id);
    }
}
