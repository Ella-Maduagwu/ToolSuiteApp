using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;
using Microsoft.VisualBasic.ApplicationServices;
using toolsuiteapp.View;

namespace toolsuiteapp.Data
{
    public class UserRepository
    {
        private readonly string _connectionString;
        public UserRepository()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["MyDBConnectionString"].ConnectionString;
        }

        public void AddUser(toolsuiteapp.Model.userAccount user)
        {
            using(var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = "INSERT INTO users (FirstName, LastName, EmailAddress, PasswordHash, Salt) VALUES (@firstName, @lastName, @emailAddress, @passwordHash, @salt)";
                // if i dont eventually create a salt, remember to remove salt from this query 
                command.Parameters.AddWithValue("@FirstName", user.firstName);
                command.Parameters.AddWithValue("@LastName", user.lastName);
                command.Parameters.AddWithValue("@EmailAdress", user.email);
                    command.Parameters.AddWithValue("@PasswordHash", user.passwordHash);
                command.Parameters.AddWithValue("@firstName", user.firstName);
                //to-do: redo the table in the db
                // do the salt
                // edit the last command above for the salt 

                command.ExecuteNonQuery();
            }
        }
    }
}
