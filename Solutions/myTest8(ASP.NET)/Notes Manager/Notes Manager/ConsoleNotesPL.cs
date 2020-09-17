using Notes.BLL.Common;
using Notes.BLL.Dependencies;
using Notes.Entities;
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
        static void Main(string[] args)
        {
            var pl = new ConsoleNotesPL();

            pl.DisplayAllNotes();
        }

        private INotesBLL _bll;

        public ConsoleNotesPL()
        {
            _bll = NotesBLLDependencies.NotesBLL;
        }

        public bool AddNote()
        {
            Console.WriteLine("Adding new note:" + Environment.NewLine);
            Console.WriteLine("Input the title:" + Environment.NewLine);
            var title = Console.ReadLine();

            Console.WriteLine("Input text of the note:" + Environment.NewLine);
            var text = Console.ReadLine();

            return _bll.SaveNote(new Note(title, text));
        }

        public void DisplayAllNotes()
        {
            var notes = _bll.GetAllNotes();

            Console.WriteLine("Current saved notes:" + Environment.NewLine);

            foreach (var item in notes)
            {
                Console.WriteLine(string.Format("Note. Date: {0}, Title: {1}, Text: {2}", 
                    item.Date, item.Title, item.Text));
            }
        }
    }
}
