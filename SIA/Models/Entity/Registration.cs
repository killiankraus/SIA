//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SIA.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Registration
    {
        public int RegistrationFormID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string AddressLines { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Fullname { get; set; }
        public string Contact { get; set; }
        public Nullable<System.DateTime> Birthdate { get; set; }
        public Nullable<int> Age { get; set; }
    }
}