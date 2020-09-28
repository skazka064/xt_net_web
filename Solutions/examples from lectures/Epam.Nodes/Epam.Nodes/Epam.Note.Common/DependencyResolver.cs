using Epam.Nodes.BLL;
using Epam.Nodes.BLL.Intefaces;
using Epam.Nodes.DAL;
using Epam.Nodes.DAL.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Note.Common
{
    public static class DependencyResolver
    {
        private static readonly INoteLogic _notesLogic ;
        private static readonly INotesDao _notesDao;

        public static INoteLogic NoteLogic => _notesLogic;


        public static INotesDao NotesDao => _notesDao;

        static DependencyResolver()
        {
            _notesDao = new NoteDao();
            _notesLogic = new NotesLogic(_notesDao);
        }
    }
}
