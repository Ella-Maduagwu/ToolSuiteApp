using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;
using Microsoft.VisualBasic.ApplicationServices;
using toolsuiteapp.View;
using toolsuiteapp.Model;

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
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = "INSERT INTO users (firstname, lastname, emailaddress, passwordhash, salt, role) VALUES (@firstname, @lastname, @emailaddress, @passwordhash, @salt, @role)";
         
                command.Parameters.AddWithValue("@firstname", user.firstName);
                command.Parameters.AddWithValue("@lastname", user.lastName);
                command.Parameters.AddWithValue("@emailaddress", user.email);
                    command.Parameters.AddWithValue("@passwordhash", user.passwordHash);
                command.Parameters.AddWithValue("@salt", user.passwordSalt);
                command.Parameters.AddWithValue("@role", user.role);
                command.ExecuteNonQuery();
            }
        }

        public bool EmailExists(string emailAddress)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new MySqlCommand("SELECT COUNT(1) FROM users WHERE email = @email", connection))
                {
                    command.Parameters.AddWithValue("@email", emailAddress);// add email address as a parameter to SQL command 
                    // to protect against SQL injection attacks 
                    // ExecuteScalar returns the first column of the first row in the resut set
                    int userCount = Convert.ToInt32(command.ExecuteScalar());
                    return userCount > 0;
                }

            }
        }
       
        

        public (string passwordHash, string Salt) GetUserPasswordInfo(string emailAddress1)
        {
            // Default values for the tuple elements
            string defaultPasswordHash = string.Empty;
            string defaultSalt = string.Empty;
           

            using (var connection = new MySqlConnection(_connectionString))
                {
                try { 
                    connection.Open();

                    string query = "SELECT passwordhash, salt, role FROM users WHERE emailaddress = @email";

                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@email", emailAddress1);
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string PasswordHash = reader["passwordhash"]?.ToString() ?? defaultPasswordHash;
                                string Salt = reader["salt"].ToString() ?? defaultSalt;
                                return (PasswordHash, Salt);
                            }
                        }

                    }
                }
                catch( Exception ex)
                {
                    Console.WriteLine( "Error retrieving password info from database");
                }
               
            }
            return (defaultPasswordHash, defaultSalt);
        }


        public (string firstName, string Role) GetUserRole(string emailAddress1)
        {
            string defaultName = string.Empty;
            string defaultRole = "User";

            using (var connection = new MySqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT passwordhash, salt, role FROM users WHERE emailaddress = @email";

                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@email", emailAddress1);
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string firstName = reader["firstname"].ToString() ?? defaultName;
                                string Role = reader["role"].ToString() ?? defaultRole;
                                return (firstName, Role);
                            }
                        }

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error retrieving password info from database");
                }

            }
            return (defaultName, defaultRole);
        }

        public void StorePasswordResetToken(string userEmail, string resetToken, DateTime tokenExpiry)
        {
            using ( var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = "UPDATE users SET ResetToken = @resetToken, TokenExpiry = @tokenExpiry WHERE EmailAddress = @userEmail";

                command.Parameters.AddWithValue ("@resetToken", resetToken);
                command.Parameters.AddWithValue("@tokenExpiry", tokenExpiry);
                command.Parameters.AddWithValue("@userEmail", userEmail);// check what the email coloumn is named as 

                command.ExecuteNonQuery();
            }

        }

        public (string resetToken, DateTime? tokenExpiry) GetResetTokenInfo(string emailAddress)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();

                string query = "SELECT ResetToken, TokenExpiry FROM users WHERE EmailAddress = @email";// this line is to prevent Injection attacks 
                using ( var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@email", emailAddress);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string resetToken = reader["ResetToken"] as string;
                            DateTime? tokenExpiry = reader.IsDBNull(reader.GetOrdinal("TokenExpiry")) ? (DateTime?)null : reader.GetDateTime(reader.GetOrdinal("TOkenExpiry"));

                            return (resetToken, tokenExpiry);
                        }

                    }
                }
            }

            return (null, null);
        }
       
        public void UpdateUserPassword(string emailAddress, string newHashedPassword,string newSalt)
        {
            using var connection = new MySqlConnection(_connectionString);
            connection.Open();

            var command = connection.CreateCommand();
            command.CommandText = "UPDATE users SET PasswordHash = @PasswordHash,Salt = @Salt WHERE EmailAddress = @Email"; // check that the parameters align with the ones in the DB
            command.Parameters.AddWithValue("@PasswordHash", newHashedPassword);
            command.Parameters.AddWithValue("@Salt", newSalt);
            command.Parameters.AddWithValue("@Email", emailAddress);

            command.ExecuteNonQuery();

            // add error handling and logger
        }


        public void ClearResetToken(string emailAddress)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "UPDATE users SET ResetToken = NULL, Token Expiry = NULL WHERE EmailAddress = @Email";
                command.Parameters.AddWithValue("@Email", emailAddress);

                command.ExecuteNonQuery();
            }
        }
        public List<SoftwareCategoriesModel> GetSoftwareCategories()
        {
            List<SoftwareCategoriesModel> categories = new List<SoftwareCategoriesModel>();
            using var connection = new MySqlConnection(_connectionString);
                connection.Open();
            var command = connection.CreateCommand();


            return categories;
            }

        public void AddCategory(SoftwareCategoriesModel category)
        {

        }

        public void DeleteCategory(SoftwareCategoriesModel category)
        {

        }
    
    }
}
