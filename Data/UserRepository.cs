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
            using (MySqlConnection connection = new MySqlConnection(_connectionString))
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

        public bool EmailExists(string emailAddress)
        {
            using (var connection = new MySqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new MySqlCommand("SELECT COUNT(1) FROM users WHERE Email = @Email", connection))
                {
                    command.Parameters.AddWithValue("@Email", emailAddress);// add email address as a parameter to SQL command 
                    // to protect against SQL injection attacks 
                    // ExecuteScalar returns the first column of the first row in the resut set
                    int userCount = Convert.ToInt32(command.ExecuteScalar());
                    return userCount > 0;
                }

            }
        }
       
        

        public (string passwordHash, string Salt, string role) GetUserPasswordInfo(string emailAddress1)
        {
                using (var connection = new MySqlConnection(_connectionString))
                {
                try { 
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
                                string role = reader["role"] as string;
                                return (PasswordHash, Salt, role);
                            }
                        }

                    }
                }
                catch
                {
                    // maybe put the logger here 
                }
                return (null, null);
            } 
            

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
            using (var connection =new MySqlConnection(_connectionString))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = "UPDATE users SET PasswordHash = @PasswordHash,Salt = @Salt WHERE EmailAddress = @Email"; // check that the parameters align with the ones in the DB
                command.Parameters.AddWithValue("@PasswordHash", newHashedPassword);
                command.Parameters.AddWithValue("@Salt", newSalt);
                command.Parameters.AddWithValue("@Email", emailAddress);

                command.ExecuteNonQuery();
            }

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
        
    
    }
}
