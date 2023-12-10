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
    internal class VendorRepository
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["MyDBConnectionString"].ConnectionString;

        public Vendor Get(int id)
        {
            using var connection = new MySqlConnection(_connectionString);
            connection.Open();

            var command = connection.CreateCommand();
            command.CommandText = @"
            SELECT vendor.*, vendor_contact_number.* 
            FROM vendor
            JOIN vendor_contact_number ON vendor_contact_number.vendor_id = vendor.vendor_id
            WHERE vendor_id = @Id;";
            command.Parameters.AddWithValue("Id", id);

            using var reader = command.ExecuteReader();
            var vendor = new Vendor();

            if (reader.Read())
            {
                vendor.Id = reader.GetInt32("vendor_id");
                vendor.Name = reader.GetString("vendor_name");
                vendor.Locations = reader.GetString("vendor_location");
                vendor.DateEstablished = DateOnly.FromDateTime(reader.GetDateTime("establishment_date"));
                vendor.ContactNumbers = reader.GetString("phone_numbers");
                vendor.WebsiteUrl = reader.GetString("website_url");
                vendor.EmployeeAmount = reader.GetInt32("number_of_employee");
            }

            connection.Close();

            return vendor;
        }

        public void Update(Vendor vendor)
        {
            using var connection = new MySqlConnection(_connectionString);
            connection.Open();

            using var command = connection.CreateCommand();
            command.CommandText = @"
            UPDATE vendor, vendor_contact_number
            JOIN vendor_contact_number on vendor_contact_number.vendor_id = vendor.vendor_id
            SET 
                vendor.vendor_name = @NewName, 
                vendor.vendor_location = @NewLocations, 
                vendor.establishment_date = @NewDateEstablished, 
                vendor.website_url = @NewWebsiteUrl, 
                vendor.number_of_employee = @NewEmployeeAmount 
                vendor_contact_number.phone_numbers = @ContactNumbers
            WHERE vendor.vendor_id = @VendorId";
            command.Parameters.AddWithValue("@VendorId", vendor.Id);
            command.Parameters.AddWithValue("@NewName", vendor.Name);
            command.Parameters.AddWithValue("@NewLocations", vendor.Locations);
            command.Parameters.AddWithValue("@NewDateEstablished", vendor.DateEstablished);
            command.Parameters.AddWithValue("@NewContactNumbers", vendor.ContactNumbers);
            command.Parameters.AddWithValue("@NewWebsiteUrl", vendor.WebsiteUrl);
            command.Parameters.AddWithValue("@NewEmployeeAmount", vendor.EmployeeAmount);
            command.Parameters.AddWithValue("@ContactNumbers", vendor.ContactNumbers);

            command.ExecuteNonQuery();

            connection.Close();
        }
    }
}
