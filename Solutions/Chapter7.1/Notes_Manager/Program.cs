using Notes.DAL.Dependencies;
using Notes.PL.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes_Manager
{
    class Program
    {
        static void Main(string[] args)
        {
            var pl = new ConsoleNotesPL();
            /*pl.AddUser();
            pl.AddUser();
            pl.AddUser();*/
            pl.DisplayAllUsers();


        }

    }
}
