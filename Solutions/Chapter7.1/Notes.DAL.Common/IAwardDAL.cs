using Notes.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.DAL.Common
{
    public interface IAwardDAL
    {
        void SaveAward(Award award);
        void DeleteAward(Guid id);
        IEnumerable<Award> GetAllAwards();
        Award GetAwardByID(Guid id);
    }
}
