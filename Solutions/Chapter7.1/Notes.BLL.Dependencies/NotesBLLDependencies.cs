using Notes.BLL.Common;


namespace Notes.BLL.Dependencies
{
    public static class NotesBLLDependencies
    {
       
        private static INotesBLL _notesBLL;
        private static IAwardBLL _awardBLL;


        public static INotesBLL NotesBLL => _notesBLL ?? (_notesBLL = new NotesManager());
       
        public static IAwardBLL AwardBLL => _awardBLL ?? (_awardBLL = new AwardBLL());


    }
}
