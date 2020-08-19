using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestionare_Parc_Auto.Classes
{
    class Users
    {
        public int Id_user { get; set; }

        public string First_name { get; set; }

        public string Last_name { get; set; }

        public string Email { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Adress { get; set; }

        public string Gender { get; set; }

        public string User_type { get; set; }

        public string Phone { get; set; }

        public Users()
        {

        }
    }
}
