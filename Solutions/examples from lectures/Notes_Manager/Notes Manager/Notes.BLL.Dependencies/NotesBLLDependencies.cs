using Notes.BLL.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.BLL.Dependencies
{
    public static class NotesBLLDependencies
    {
        private static INotesBLL _notesBLL;
        public static INotesBLL NotesBLL => _notesBLL ?? (_notesBLL = new NotesManager());
    }
}
