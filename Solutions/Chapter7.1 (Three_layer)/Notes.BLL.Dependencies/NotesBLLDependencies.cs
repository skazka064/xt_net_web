using Notes.BLL.Common;


namespace Notes.BLL.Dependencies
{
    public static class NotesBLLDependencies
    {
       
        private static INotesBLL _notesBLL;
        
        
        public static INotesBLL NotesBLL => _notesBLL ?? (_notesBLL = new NotesManager());
      

    }
}
