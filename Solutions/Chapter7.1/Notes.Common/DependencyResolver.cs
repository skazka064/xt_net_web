using Notes.PL.Common;

namespace DependencyResolver
{
    public static class DependencyResolver
    {
        public static INotesPL NotesDAL => new JsonNotesDAO();
    }
}