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

        public void AddUser(Model.UserAccount user)
        {
            using(var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = "INSERT INTO users (FirstName, LastName, EmailAddress, PasswordHash, Salt) VALUES (@firstName, @lastName, @emailAddress, @passwordHash, @salt)";
         
                command.Parameters.AddWithValue("@FirstName", user.firstName);
                command.Parameters.AddWithValue("@LastName", user.lastName);
                command.Parameters.AddWithValue("@EmailAddress", user.email);
                    command.Parameters.AddWithValue("@PasswordHash", user.passwordHash);
                command.Parameters.AddWithValue("@Salt", user.passwordSalt);
                command.ExecuteNonQuery();
            }
        }
      
       /** public bool emailExists(string email)
        {
            using ( var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
               using( var command = new MySqlCommand("SELECT COUNT(1) FROM users WHERE Email = @Email", connection)) {
                    command.Parameters.AddWithValue("@Email", email);// add email address as a parameter to SQL command 
                    // to protect against SQL injection attacks 
                    // ExecuteScalar returns the first column of the first row in the resut set
                    int userCount = Convert.ToInt32(command.ExecuteScalar());
                    return userCount > 0;
                }
               
            }
       **/
        

        public (string passwordHash, string Salt) GetUserPasswordInfo(string emailAddress1)
        {
            try
            {
                using (var connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();

                    string query = "SELECT passwordHash, salt FROM users WHERE emailaddress = @Email";

                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", emailAddress1);
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string PasswordHash = reader["passwordHash"] as string;
                                string Salt = reader["salt"] as string;
                                return (PasswordHash, Salt);
                            }
                        }

                    }
                }
                return (null, null);
            } 
            catch { 
            // maybe i can put the logger here 
            }

        }
       
        
    
    }
}
