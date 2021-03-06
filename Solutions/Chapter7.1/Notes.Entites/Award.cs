﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Entites
{
    public class Award
    {
        public Guid ID { get; set; }

        public string Title { get; set; }

        public Award()
        {
            ID = Guid.NewGuid();
        }
        public Award(string title) : this()
        {
            Title = title ?? throw new ArgumentNullException(nameof(title));
        }
    }
}
