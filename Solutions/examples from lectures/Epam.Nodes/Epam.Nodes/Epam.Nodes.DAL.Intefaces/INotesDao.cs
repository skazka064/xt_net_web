using Epam.Nodes.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Nodes.DAL.Intefaces
{
    public interface INotesDao
    {
        int Add(Note note);

        void DeleteById(int id);

        IEnumerable<Note> GetAll();
    }
}
