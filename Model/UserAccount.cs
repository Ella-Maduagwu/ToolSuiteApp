using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace toolsuiteapp.Model
{
   
    public class UserAccount
    {
        public string firstName {  get; set; }// change the case of the properties
        public string lastName { get; set; }
        public string email { get; set; }
        public string passWord { get; set; }
        public string passwordHash { get; set; } 
        public string passwordSalt { get; set; } 
        public string role { get; set; }
    }
}
