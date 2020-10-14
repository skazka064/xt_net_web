using System;
using System.Collections.Generic;
using Notes.BLL.Common;
using Notes.Entites;

namespace Notes.BLL
{
    public class NotesManager : INotesBLL

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
