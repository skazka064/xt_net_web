using Notes.BLL.Common;
using Notes.Common;
using Notes.DAL.Dependencies;
using Notes.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.BLL
{
    public class NotesManager : INotesBLL
    {
        private INotesDAL _notesDAO;

        public NotesManager()
        {
            _notesDAO = NotesDALDependencies.NotesDAL;
        } 

        public IEnumerable<Note> GetAllNotes()
        {
            // TODO: logging, send messages
            return _notesDAO.GetAllNotes();
        }

        public Note GetNoteByID(Guid id)
        {
            // TODO: logging, send messages
            return _notesDAO.GetNoteByID(id);
        }

        public bool SaveNote(Note note)
        {
            try
            {
                // TODO: logging, send messages
                _notesDAO.SaveNote(note);
                return true;
            }
            catch
            {
                // TODO: checking more exceptions
                return false;
            }
        }
    }
}
