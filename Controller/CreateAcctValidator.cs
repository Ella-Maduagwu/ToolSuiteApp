using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using toolsuiteapp.View;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace toolsuiteapp.Controller 
{

  public class CreateAcctValidator
    {
        
        public List<string> acctValidators( string firstName, string lastName, string emailAddress, string password, string confirmPassword)
        {
            
            List<string> errors = new List<string>();
            

            if (string.IsNullOrEmpty(firstName)) 
            {
                errors.Add("please fill all textboxes");
            }

            if (string.IsNullOrEmpty(lastName))
            {
                errors.Add("please fill all textboxes");
            }

            if (string.IsNullOrEmpty(emailAddress))
            {
                errors.Add("please fill all textboxes");
            }
            if (string.IsNullOrEmpty(password))
            {
                errors.Add("please fill all textboxes");
            }

            if (string.IsNullOrEmpty(confirmPassword))
            {
                errors.Add("please fill all textboxes");
            }
            if (password != confirmPassword)
            {
                errors.Add("passwords do not match");
            }

            return errors;
        }

        public static string GenerateSalt(int size = 32)// can change the size later 
        {
            using (var rng = new RNGCryptoServiceProvider())// use RNGCryptoServiceProvider class to generate secure random salt 
            {
                var saltBytes = new byte[size];
                rng.GetBytes(saltBytes);
                return Convert.ToBase64String(saltBytes);
            }
        }

        //hash the password

        public static string hashPassword(string password,string salt)
        {
            using (var sha256  = SHA256.Create())//creates new instance of the hash algorithm
            { 
                var saltedPassword = string.Concat(password, salt);// concatenate password and salt before hashing 
                byte[] saltedPasswordBytes = Encoding.UTF8.GetBytes(saltedPassword);// convert into a byte array
                byte[] hashBytes = sha256.ComputeHash((saltedPasswordBytes));// compute the hash 

                StringBuilder builder = new StringBuilder();
                foreach(var b in hashBytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();// returns the complete hash as a string 
            }
            
        }

        
        
       

       

        

    

       
    }
}
