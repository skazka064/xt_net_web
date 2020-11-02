using Notes.BLL.Common;
using Notes.DAL.Common;
using Notes.DAL.Dependencies;
using Notes.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.BLL 
{
   public class AwardBLL :IAwardBLL
    {
        private IAwardDAL _awardDAL;
        public AwardBLL()
        {
            _awardDAL = NotesDALDependencies.AwardDAL;
        }

        public bool DeleteAward(Guid id)
        {
            try
            {
                _awardDAL.DeleteAward(id);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public IEnumerable<Award> GetAllAwards()
        {
            return _awardDAL.GetAllAwards();
        }

        public Award GetAwardByID(Guid id)
        {
            return _awardDAL.GetAwardByID(id);
        }

        public bool SaveAward(Award award)
        {
            try
            {
                _awardDAL.SaveAward(award);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
