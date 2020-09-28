using Epam.Nodes.DAL.Intefaces;
using Epam.Nodes.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Epam.Nodes.DAL
{
    public class NoteDao : INotesDao
    {
        private string _connectionString = "Data Source=.;Initial Catalog=NotesDb;Integrated Security=True";
        public int Add(Note note)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var command = connection.CreateCommand();
                command.CommandText = "AddNote";
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter
                {
                    ParameterName = "@Text",
                    Value = note.Text,
                    SqlDbType = SqlDbType.NVarChar,
                    Direction = ParameterDirection.Input
                });

                command.Parameters.Add(new SqlParameter
                {
                    ParameterName = "@DateCreation",
                    Value = note.DateCreation,
                    SqlDbType = SqlDbType.DateTime,
                    Direction = ParameterDirection.Input
                });

                var id = new SqlParameter
                {
                    ParameterName = "@Id",
                    SqlDbType = SqlDbType.Int,
                    Direction = ParameterDirection.Output
                };
                command.Parameters.Add(id);

                connection.Open();

                command.ExecuteNonQuery();

                return (int)id.Value;
            }
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Note> GetAll()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT [Id]"
                    +",[DateCreation]"
                    +",[Text]"
                    +"FROM[NotesDb].[dbo].[Notes]";
                connection.Open();

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine((int)reader["Id"]);
                    yield return new Note
                    {
                        Id = (int)reader["Id"],
                        Text = (string)reader["Text"],
                        DateCreation = (DateTime)reader["DateCreation"],
                    };
                }
            }
        }
    }
}
