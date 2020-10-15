using Notes.DAL.Common;


namespace Notes.DAL.Dependencies
{
    public static class NotesDALDependencies
    {
        private static INotesDAL _notesDAL;
       
        public static INotesDAL NotesDAL => _notesDAL ?? (_notesDAL = new JsonNotesDAO());
       
    }
}
