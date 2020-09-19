using Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public interface IUserDAL
    {
        void Add(Users user);
        IEnumerable<Users> GetAllUsers();
        void GetUserByID(Guid id);
    }
}
