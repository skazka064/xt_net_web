using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Entities
{
    public class Note
    {
        public Guid ID { get; set; }

        public DateTime Date { get; set; }

        public string Title { get; set; }

        public string Text { get; set; }

        protected Note()
        {
            ID = Guid.NewGuid();
            Date = DateTime.Now;
        }

        public Note(string title, string text) : this()
        {
            Title = title ?? throw new ArgumentNullException(nameof(title));
            Text = text ?? throw new ArgumentNullException(nameof(text));
        }
    }
}
