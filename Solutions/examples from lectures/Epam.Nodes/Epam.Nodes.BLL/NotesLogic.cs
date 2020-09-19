using Epam.Nodes.BLL.Intefaces;
using Epam.Nodes.DAL.Intefaces;
using Epam.Nodes.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Nodes.BLL
{
    public class NotesLogic: INoteLogic
    {
        private readonly INotesDao _notesDao;

        public NotesLogic(INotesDao notesDao)
        {
            _notesDao = notesDao;
        }
        public int Add(Note note)
        {


            return _notesDao.Add(note);
        }

        public void DeleteById(int id)
        {
            _notesDao.DeleteById(id);
        }

        public IEnumerable<Note> GetAll()
        {
            return _notesDao.GetAll();
        }

        public Note GtById(int id)
        {
            return _notesDao.GetAll().FirstOrDefault(item => item.Id == id);
        }
    }
}
