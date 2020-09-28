using Epam.Note.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Epam.Nodes.Entities;

namespace Epam.Nodes.ConsolePL
{
    class Program
    {
        static void Main(string[] args)
        {
            var notesLogic = DependencyResolver.NoteLogic;

            //var addedId = notesLogic.Add(new Entities.Note()
            //{
            //    Text = "Bla bla",
            //    DateCreation = DateTime.Now
            //});



            //Console.WriteLine(addedId);

            //foreach (var item in notesLogic.GetAll())
            //{
            //    Console.WriteLine($"{item.Id} {item.Text}");
            //}

            notesLogic.GtById(1);
        }
    }
}
