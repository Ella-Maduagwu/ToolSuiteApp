using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using toolsuiteapp.View;
using System.Security.Cryptography;

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

        //hash the password

        public static string hashPassword(string password)
        {
            using (var sha256  = SHA256.Create())//creates new instance of the hash algorithm
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
            
        }

        
        
       

       

        

    

       
    }
}
