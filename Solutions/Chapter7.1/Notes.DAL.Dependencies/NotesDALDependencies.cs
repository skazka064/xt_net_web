using Notes.BLL.Common;
using Notes.DAL.Common;


namespace Notes.DAL.Dependencies
{
    public static class NotesDALDependencies
    {
        private static INotesDAL _notesDAL;
        private static IAwardDAL _awardDAL;
       
        public static INotesDAL NotesDAL => _notesDAL ?? (_notesDAL = new JsonNotesDAO());
        public static IAwardDAL AwardDAL => _awardDAL ?? (_awardDAL = new JsonAwardDAL());
       
    }
}
