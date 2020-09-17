using Notes.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.DAL.Common
{
    public interface INotesDAL
    {
        void SaveNote(Note note);
        IEnumerable<Note> GetAllNotes();
        Note GetNoteByID(Guid id);
    }
}
