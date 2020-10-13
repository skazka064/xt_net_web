using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Notes.Common;
using Notes.Entites;

namespace Notes.BLL
{
    class NotesManager : INotesBLL

    {
        public IEnumerable<User> GetAllUser()
        {
            throw new NotImplementedException();
        }

        public User GetUserByID(Guid id)
        {
            throw new NotImplementedException();
        }

        public void SaveUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
