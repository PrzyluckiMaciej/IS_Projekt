using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_app.Authentication
{
    public class User
    {
        public string username {  get; set; }
        public string password { get; set; }
        public string token { get; set; }
        public User( string username, string password)
        {
            this.username = username;
            this.password = password;
        }        
    }
}
