using Notes.BLL;
using Notes.BLL.Common;
using Notes.Common;
using Notes.DAL;
using Notes.PL.Common;
using Notes_Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyResolver
{
    public static class DependencyResolver
    {
        private static INotesDAL _notesDAL;
        private static INotesBLL _notesBLL;
        private static INotesPL _notesPL;

        public static INotesDAL NotesDAL => _notesDAL ?? (_notesDAL = new JsonNotesDAO());
        public static INotesBLL NotesBLL => _notesBLL ?? (_notesBLL = new NotesManager());
        public static INotesPL NotesPL => _notesPL ?? (_notesPL = new ConsoleNotesPL());
    }
}
