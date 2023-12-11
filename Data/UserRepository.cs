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
using System.Net.Mail;
using System.Security.Cryptography.X509Certificates;
using toolsuiteapp.Service;
using System.Diagnostics.Eventing.Reader;
using toolsuiteapp.Data;

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
        {try
            {
                using MySqlConnection connection = new(_connectionString);
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
            catch(Exception ex)
            {
               Logger logger = new Logger();
                logger.LogException(ex);
            }
          

        }

        public bool EmailExists(string emailAddress)
        {
            using var connection = new MySqlConnection(_connectionString);
            connection.Open();
            using var command = new MySqlCommand("SELECT COUNT(1) FROM users WHERE emailaddress = @email", connection);
            command.Parameters.AddWithValue("@email", emailAddress);//  in the resut set
            int userCount = Convert.ToInt32(command.ExecuteScalar());
            return userCount > 0;
        }



        public (string passwordHash, string Salt) GetUserPasswordInfo(string emailAddress1)
        {
            // Default values for the tuple elements
            string defaultPasswordHash = string.Empty;
            string defaultSalt = string.Empty;


            using (var connection = new MySqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT passwordhash, salt FROM users WHERE emailaddress = @email";

                    using var command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@email", emailAddress1);
                    using var reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        string PasswordHash = reader["passwordhash"]?.ToString() ?? defaultPasswordHash;
                        string Salt = reader["salt"].ToString() ?? defaultSalt;
                        return (PasswordHash, Salt);
                    }
                }
                catch (Exception ex)
                {
                    Logger logger = new Logger();
                        logger.LogException(ex);
                }

            }
            return (defaultPasswordHash, defaultSalt);
        }


        public string GetUserRole(string emailAddress1)
        {
            string defaultRole = "User";

            using (var connection = new MySqlConnection(_connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT role FROM users WHERE emailaddress = @email";

                    using var command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@email", emailAddress1);
                    using var reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        string Role = reader["role"].ToString() ?? defaultRole;
                        return  Role;
                    }


                }
                catch (Exception ex)
                {
                    Logger logger = new Logger();
                        logger.LogException(ex);
                    
                }

            }
            return defaultRole;
        }

        public void StorePasswordResetToken(string userEmail, string resetToken, DateTime tokenExpiry)
        {// use this method wqhen you're trying to store the vendors 
            try
            {
                using var connection = new MySqlConnection(_connectionString);
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = "UPDATE users SET resettoken = @resetToken, tokenexpiry = @tokenExpiry WHERE emailaddress = @userEmail";

                command.Parameters.AddWithValue("@resetToken", resetToken);
                command.Parameters.AddWithValue("@tokenExpiry", tokenExpiry);
                command.Parameters.AddWithValue("@userEmail", userEmail);// check what the email coloumn is named as 

                command.ExecuteNonQuery();
            } 
            catch (Exception ex)
            {
                Logger logger = new Logger();
                logger.LogException(ex);
            }

        }

        public (string resetToken, DateTime? tokenExpiry) GetResetTokenInfo(string emailAddress)
        {
            try
            {
                using (var connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();

                    string query = "SELECT ResetToken, TokenExpiry FROM users WHERE EmailAddress = @email";// this line is to prevent Injection attacks 
                    using var command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@email", emailAddress);
                    using var reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        string resetToken = reader["ResetToken"] as string;
                        DateTime? tokenExpiry = reader.IsDBNull(reader.GetOrdinal("TokenExpiry")) ? (DateTime?)null : reader.GetDateTime(reader.GetOrdinal("TOkenExpiry"));

                        return (resetToken, tokenExpiry);
                    }
                }

            } 
            catch(Exception ex)
            {
                Logger logger = new Logger();
                logger.LogException(ex);
            }
            return (null, null);
        }

        public void UpdateUserPassword(string emailAddress, string newHashedPassword, string newSalt)
        {
            try
            {


                using var connection = new MySqlConnection(_connectionString);
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = "UPDATE users SET PasswordHash = @PasswordHash,Salt = @Salt WHERE EmailAddress = @Email"; // check that the parameters align with the ones in the DB
                command.Parameters.AddWithValue("@PasswordHash", newHashedPassword);
                command.Parameters.AddWithValue("@Salt", newSalt);
                command.Parameters.AddWithValue("@Email", emailAddress);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Logger logger = new Logger();
                logger.LogException(ex);
            }

            
        }


        public void ClearResetToken(string emailAddress)
        {
            try
            {

                using var connection = new MySqlConnection(_connectionString);
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "UPDATE users SET ResetToken = NULL, Token Expiry = NULL WHERE emailaddress = @Email";
                command.Parameters.AddWithValue("@email", emailAddress);

                command.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                Logger logger = new Logger();
                logger.LogException(ex);
            }
        }
        public List<SoftwareCategoriesModel> GetSoftwareCategories()
        {
            List<SoftwareCategoriesModel> categories = new();
            try
            {

                using var connection = new MySqlConnection(_connectionString);
                connection.Open();
                
                var command = connection.CreateCommand();
                command.CommandText = "SELECT name FROM software_category";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var category = new SoftwareCategoriesModel
                        {
                            Name = reader.GetString("name"),
                        };

                    categories.Add(category);
                    }
                    
                }
            }

            catch (Exception ex)
            {
                Logger logger = new Logger();
                logger.LogException(ex);
            }
            return categories;
        }

        public void AddCategory(Model.SoftwareCategoriesModel softwares)
        {
            try
            {
                using var connection = new MySqlConnection(_connectionString);
                connection.Open();
               
                    var command = connection.CreateCommand();
                    command.CommandText = "INSERT INTO software_category(Name, softwarename, vendorname) VALUES (@name, @softwarename, @vendorname) ";
                    command.Parameters.AddWithValue("@name", softwares.Name);
                command.Parameters.AddWithValue("@softwarename", softwares.SoftwareName);
                command.Parameters.AddWithValue("@vendorname", softwares.VendorName);
                command.ExecuteNonQuery();
               
            }
            catch(Exception ex) 
            {
                Logger logger = new Logger();
                logger.LogException(ex);
            }
        }

        public void DeleteCategory(SoftwareCategoriesModel category)
        {
            try
            {
                using var connection = new MySqlConnection(_connectionString);
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "DELETE FROM software_category(Name) VALUES (@name) ";
                command.Parameters.AddWithValue("@name", category.Name);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Logger logger = new Logger();
                logger.LogException(ex);
            }
        }

        public void UpdateCategory(SoftwareCategoriesModel category)
        {
            try
            {
                using var connection = new MySqlConnection(_connectionString);
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "UPDATE software_category SET Name = @name WHERE Id = @id";
               
                command.Parameters.AddWithValue("@name", category.Name);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Logger logger = new Logger();
                logger.LogException(ex);
            }

        }

        public List<SoftwareCategoriesModel> GetSoftwares(string categoryName)
        {
            List<SoftwareCategoriesModel> softwares = new List<SoftwareCategoriesModel>();
            try
            {
                using var connection = new MySqlConnection(_connectionString);
                connection.Open();
                var command = connection.CreateCommand();
                command.CommandText = "SELECT softwarename FROM software_category WHERE name = @categoryName";
                command.Parameters.AddWithValue("@categoryName", categoryName);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var software = new SoftwareCategoriesModel
                        {
                            SoftwareName = reader.GetString("softwarename"),
                        };

                        softwares.Add(software);
                    }
                }
            }
            catch (Exception ex)
            {
                Logger logger = new Logger();
                logger.LogException(ex);
            }

            return softwares;
        }





        public List<SearchResultModel> MultiCriteriaSearch(string searchTerm)
        {
            var results = new List<SearchResultModel>();
            try
            {


                using (var connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();

                    var query = @"SELECT * FROM software_categories WHERE Name LIKE @searchTerm ";
                    using (var command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var searchResult = new SearchResultModel
                                {
                                    // populate here 
                                };
                                results.Add(searchResult);
                            }
                        }
                    }

                }
            }

            catch (Exception ex)
            {
                Logger logger = new Logger();
                logger.LogException(ex);
            }
            return results;
        }
    }

    namespace toolsuiteapp.Controller
    {
        public class AddSoftwaresController
        {
            private UserRepository _userRepository;
            public AddSoftwaresController()
            {
                _userRepository = new UserRepository();
            }

            public void SavePictures(byte[] imageBytes)
            {
                _userRepository.SaveImagesToDB(imageBytes);
            }
            public void SaveLogo(byte[] imageBytes)
            {
                _userRepository.SaveLogoToDB(imageBytes);
            }

            public void SavePdf(byte[] pdfBytes)
            {
                _userRepository.SavePdfToDb(pdfBytes);
            }
            public Image ConvertByteArrayToImage(byte[] imageBytes)
            {
                using (var ms = new MemoryStream())
                {
                    return Image.FromStream(ms);
                }
            }
        }
    }
    public void SaveImagesToDB(byte[] imagebytes)
    {
        try
        {
            using var connection = new MySqlConnection(_connectionString);
            connection.Open();

            var command = new MySqlCommand("INSERT INTO softwares (logo) VALUES (@Image)", connection);
            command.Parameters.AddWithValue("@Image", imagebytes);

            // Execute the command to insert data into the database
            command.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            Logger logger = new Logger();
            logger.LogException(ex);
        }
    }

    public void SavePdfToDb(byte[] pdfbytes)
    {
        try
        {
            using var connection = new MySqlConnection(_connectionString);
            connection.Open();
            var command = new MySqlCommand("INSERT INTO software (pdf) VALUES (@File)", connection);
            command.Parameters.AddWithValue("@File", pdfbytes);
        }
        catch (Exception ex)
        {
            Logger logger = new Logger();
            logger.LogException(ex);
        }
    }
    public byte[] GetLogoImage(string softwareName)
    {
        byte[] imagebytes = null;
        try
        {
            using var connection = new MySqlConnection(_connectionString);
            connection.Open();
            var command = new MySqlCommand("SELECT logo FROM softwares WHERE software_name = @softwareName", connection);
            command.Parameters.AddWithValue("@softwareName", softwareName);
            using (var reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    imagebytes = (byte[])reader["logo"];
                }
            }
        }

        catch (Exception ex)
        {
            Logger logger = new Logger();
            logger.LogException(ex);
        }



        return imagebytes;
    }


}


