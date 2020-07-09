using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pleres.Classes
{
    public class UserModel
    {
        public int Id { get; set; }
        private string Username { get; set; }
        private string Password { get; set; }
        private int Permissions { get; set; }

        private string Firstname { get; set; }
        private string Lastname { get; set; }

        private string FullName
        {
            get
            {
                return $"{Firstname} {Lastname}";
            }
        }
        private string Dateadded { get; set; }
        private string Birthday { get; set; }
    }
}
