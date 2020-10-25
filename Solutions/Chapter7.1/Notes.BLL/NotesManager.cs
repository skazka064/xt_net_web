using System;
using System.Collections.Generic;
using Notes.BLL.Common;
using Notes.DAL.Common;
using Notes.DAL.Dependencies;
using Notes.Entites;

namespace Notes.BLL
{
    public class NotesManager : INotesBLL

    {
       
        private INotesDAL _notesDAO;
        public NotesManager()
        {
            _notesDAO = NotesDALDependencies.NotesDAL;
        }


        public IEnumerable<User> GetAllUser()
        {
            return _notesDAO.GetAllUser();
        }

        public User GetUserByID(Guid id)
        {
            return _notesDAO.GetNoteByID(id);
        }

        public bool SaveUser(User user)
        {
            try
            {
                _notesDAO.SaveUser( user);
                return true;
            }
            catch
            {
                return false;
            }
             
        }
    }
}
