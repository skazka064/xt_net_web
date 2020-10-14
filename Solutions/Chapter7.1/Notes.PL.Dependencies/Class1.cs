using Notes.PL.Common;
using Notes_Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.PL.Dependencies
{
    public static class NotesPLDependencies
    {
        private static INotesPL _notesPL;
        public static INotesPL NotesPL => _notesPL ?? (_notesPL = new ConsoleNotesPL());

    }
}
