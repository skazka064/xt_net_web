using Notes.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.BLL.Common
{
    public interface INotesBLL
    {
        bool SaveNote(Note note);
        IEnumerable<Note> GetAllNotes();
        Note GetNoteByID(Guid id);
    }
}
