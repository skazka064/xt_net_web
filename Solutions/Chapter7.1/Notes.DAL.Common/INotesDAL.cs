using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Notes.Entites;

namespace Notes.DAL.Common
{
    public interface INotesDAL
    {
        void SaveUser(User user);
        IEnumerable<User> GetAllUser();
        User GetNoteByID(Guid id);
    }
}
