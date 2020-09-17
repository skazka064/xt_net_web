using Notes.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.DAL.Dependencies
{
    public static class NotesDALDependencies
    {
        private static INotesDAL _notesDAL;
        public static INotesDAL NotesDAL => _notesDAL ?? (_notesDAL = new JsonNotesDAO());
    }
}
