using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Notes.Entites;


namespace Notes.BLL.Common
{
    public interface INotesBLL
    {
        void SaveUser(User user);
        IEnumerable<User> GetAllUser();
        User GetUserByID(Guid id);
    }
}
