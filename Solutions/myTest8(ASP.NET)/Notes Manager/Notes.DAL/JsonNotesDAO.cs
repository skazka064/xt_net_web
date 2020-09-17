using Newtonsoft.Json;
using Notes.Common;
using Notes.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Notes.DAL
{
    public class JsonNotesDAO : INotesDAL
    {
        public const string LocalDataPath = "Data\\";
        public static string DataPath => Environment.CurrentDirectory + "\\" + LocalDataPath;

        public Note GetNoteByID(Guid id) => GetAllNotes().FirstOrDefault(n => n.ID == id);

        public IEnumerable<Note> GetAllNotes()
        {
            var directory = new DirectoryInfo(Environment.CurrentDirectory + "\\" + LocalDataPath);

            foreach (var file in directory.GetFiles())
                using (var reader = new StreamReader(file.FullName))
                    yield return JsonConvert.DeserializeObject<Note>(reader.ReadToEnd());
        }

        public void SaveNote(Note note)
        {
            if (note == null)
                throw new ArgumentNullException(nameof(note));

            var noteName = "Note_" + note.ID + ".json";

            var noteStr = JsonConvert.SerializeObject(note);

            using (var writer = new StreamWriter(LocalDataPath + noteName))
                writer.Write(noteStr);
        }
    }
}
