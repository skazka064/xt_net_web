using System;
using System.Collections.Generic;
using Notes.Entites;


namespace Notes.BLL.Common
{
    public interface INotesBLL
    {
        bool SaveUser(User user);
        IEnumerable<User> GetAllUser();
        User GetUserByID(Guid id);
    }
}
