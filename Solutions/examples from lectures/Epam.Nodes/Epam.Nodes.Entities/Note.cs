using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Nodes.Entities
{
    public class Note
    {
        public int Id { get; set; }

        public string Text { get; set; }

        public DateTime DateCreation { get; set; }
    }
}
