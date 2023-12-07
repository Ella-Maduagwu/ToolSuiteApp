using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using toolsuiteapp.Controller;
using toolsuiteapp.Data;
using static System.Net.Mime.MediaTypeNames;

namespace toolsuiteapp.Service
{
    public  class UserSession
    {
        string currentUserRole = string.Empty;

        public  void Initialize(string email)
        {
            
            var userRepo = new UserRepository();
            var userRole = userRepo.GetUserRole(email);// this method returns the h
            grantAccess(userRole);
        }


        public void grantAccess(string Role)
        {
            
           
            if (Role == "Admin")
            {
                 currentUserRole = Role;


            }
            else if (Role == "User")
            {
                currentUserRole = Role;


            }
            else
            {
                MessageBox.Show("error");
                // implement logger 
            }

        }

        public string GetRole()
        {
            return currentUserRole;
        }

    }
}
