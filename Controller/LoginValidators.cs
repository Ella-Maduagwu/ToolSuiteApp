using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using toolsuiteapp.Model;
using toolsuiteapp.View;

namespace toolsuiteapp.Controller
{
    public class LoginValidators
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public List<string> detailsValidation()
        {

            List<string> errorsForLogin = new List<string>();

            if (string.IsNullOrEmpty(Email))
            {
                errorsForLogin.Add("please fill all textboxes");
            }

            if (string.IsNullOrEmpty(Password))
            {
                errorsForLogin.Add("please fill all textboxes");
            }

            return errorsForLogin;
        }
  
        //hash andsalt the password the user provided 
       
    }
}
