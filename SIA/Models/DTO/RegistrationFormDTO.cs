using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SIA.Models.DTO
{
    public class RegistrationFormDTO
    {
        public Int32 id { get; set; }

        public string Firstname { get; set; }

        public string Middlename { get; set; }

        public string Lastname { get; set; }

        public DateTime Birthdate { get; set; }

        public string Username { get; set; }
        
        public string Password { get; set; }

        public string Confirmpassword { get; set; }
    }
}