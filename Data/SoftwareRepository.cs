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
            command.CommandText = @"
            SELECT softwares.*, categories.* 
            FROM softwares 
            JOIN categories ON categories.software_id = softwares.software_id 
            WHERE softwares.software_id = @Id;";
            command.Parameters.AddWithValue("Id", id);

            using var reader = command.ExecuteReader();
            var software = new Software();

            if (reader.Read())
            {
                software.Id = reader.GetInt32("software_id");
                software.Name = reader.GetString("software_name");
                software.Description = reader.GetString("description");
                software.LastReviewed = DateOnly.FromDateTime(reader.GetDateTime("last_review_date"));
                software.LastDemoDate = DateOnly.FromDateTime(reader.GetDateTime("last_demo_date"));
                software.ImageUrl = reader.GetString("image_url");
                software.Category = reader.GetString("category_name");
            }

            connection.Close();

            return software;
        }

        public ICollection<Software> GetAll()
        {
            using var connection = new MySqlConnection(_connectionString);
            connection.Open();

            var command = connection.CreateCommand();
            command.CommandText = @"
            SELECT softwares.*, categories.* 
            FROM softwares 
            JOIN categories ON categories.software_id = softwares.software_id";

            using var reader = command.ExecuteReader();
            var softwareList = new List<Software>();

            while (reader.Read())
            {
                softwareList.Add(new()
                {
                    Id = reader.GetInt32("software_id"),
                    Name = reader.GetString("software_name"),
                    Description = reader.GetString("description"),
                    ImageUrl = reader.GetString("image_url"),
                    LastReviewed = DateOnly.FromDateTime(reader.GetDateTime("last_review_date")),
                    LastDemoDate = DateOnly.FromDateTime(reader.GetDateTime("last_demo_date")),
                    Category = reader.GetString("category_name")
                });
            }

            connection.Close();

            return softwareList;
        }
    }
}
