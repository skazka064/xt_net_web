using System;
using System.Collections.Generic;
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
