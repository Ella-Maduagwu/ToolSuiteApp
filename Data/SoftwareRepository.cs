using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using toolsuiteapp.Model;

namespace toolsuiteapp.Data
{
    public class SoftwareRepository
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["MyDBConnectionString"].ConnectionString;

        public Software Get(string id)
        {
            using var connection = new MySqlConnection(_connectionString);
            connection.Open();

            var command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM software WHERE id = @Id;";
            command.Parameters.AddWithValue("Id", id);

            using var reader = command.ExecuteReader();
            var software = new Software();

            if (reader.Read())
            {
                software.Id = reader.GetInt32("id");
                software.Name = reader.GetString("name");
                software.Description = reader.GetString("description");
                software.AdditionalInformation = reader.GetString("additional_information");
                software.ImageUrl = reader.GetString("image_url");
                software.LastReviewed = DateOnly.FromDateTime(reader.GetDateTime("last_reviewed"));
                software.Category = reader.GetString("category");
            }

            connection.Close();

            return software;
        }

        public ICollection<Software> GetAll()
        {
            using var connection = new MySqlConnection(_connectionString);
            connection.Open();

            var command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM software;";

            using var reader = command.ExecuteReader();
            var softwareList = new List<Software>();

            while (reader.Read())
            {
                softwareList.Add(new()
                {
                    Id = reader.GetInt32("id"),
                    Name = reader.GetString("name"),
                    Description = reader.GetString("description"),
                    AdditionalInformation = reader.GetString("additional_information"),
                    ImageUrl = reader.GetString("image_url"),
                    LastReviewed = DateOnly.FromDateTime(reader.GetDateTime("last_reviewed")),
                    Category = reader.GetString("category")
                });
            }

            connection.Close();

            return softwareList;
        }
    }
}
