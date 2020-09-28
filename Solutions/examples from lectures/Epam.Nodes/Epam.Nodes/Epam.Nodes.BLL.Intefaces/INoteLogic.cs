using Epam.Nodes.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Nodes.BLL.Intefaces
{
    public interface INoteLogic
    {
        int Add(Note note);

        void DeleteById(int id);

        IEnumerable<Note> GetAll();

        Note GtById(int id);
    }
}
