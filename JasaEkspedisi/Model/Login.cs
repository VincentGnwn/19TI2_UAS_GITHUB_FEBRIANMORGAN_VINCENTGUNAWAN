using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JasaEkspedisi.Model
{
    class Login
    {
        string user, password;

        public Login()
        {
            User = user;
            Password = password;
        }

        public string User { get => user; set => user = value; }
        public string Password { get => password; set => password = value; }
    }
}
