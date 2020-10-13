using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Notes.Common;

namespace Notes.Common
{
    public interface INotesPL
    {
        void DisplayAllUsers();
        bool AddUser();
    }
}
