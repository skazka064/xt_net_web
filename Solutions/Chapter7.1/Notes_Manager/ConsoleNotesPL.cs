using Notes.BLL.Common;
using Notes.BLL.Dependencies;
using Notes.DAL.Dependencies;
using Notes.PL.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Notes_Manager
{

    public class ConsoleNotesPL : INotesPL
    {
       
        private INotesBLL _bll;
        public ConsoleNotesPL()
        {
            _bll = NotesBLLDependencies.NotesBLL;
        }
        public bool AddUser()
        {
            Console.WriteLine("Adding new user: " +Environment.NewLine);
            Console.WriteLine("Input name: " + Environment.NewLine);
            var name = Console.ReadLine();
            Console.WriteLine("Input date of birth" +Environment.NewLine);
            var dateOfBirth = Console.ReadLine();
            Console.WriteLine("Input age: "+ Environment.NewLine);
            var age = Console.ReadLine();
           return _bll.SaveUser(new Notes.Entites.User(name, dateOfBirth, age));
           
            
        }

        public void DisplayAllUsers()
        {
            var users = _bll.GetAllUser() ;
            Console.WriteLine("Current user:" + Environment.NewLine);
            foreach(var user in users)
            {
                Console.WriteLine(string.Format("User. ID:{0}, Age: {1},Escho chtoto: {2}", user.ID , user.Age, user.DateOfBirth));
            }
        }
    }
}
