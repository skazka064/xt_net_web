using Notes.BLL.Common;
using Notes.BLL;
using Notes.DAL;
using Notes.DAL.Common;
using Notes.PL.Common;
using Notes_Manager;

namespace DependencyResolver
{
    public class DependencyResolver
    {
        private static INotesDAL _notesDAL;
        private static INotesBLL _notesBLL;
        private static INotesPL _notesPL;
        public static INotesDAL NotesDAL => _notesDAL ?? ( _notesDAL= new JsonNotesDAO());
        public static INotesBLL NotesBLL => _notesBLL ?? (_notesBLL = new NotesManager());
        public static INotesPL NotesPL=> _notesPL ?? (_notesPL = new ConsoleNotesPL());

    }
}
