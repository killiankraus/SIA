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
    
    public partial class Account
    {
        public int id { get; set; }
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Lastname { get; set; }
        public Nullable<System.DateTime> Birthdate { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
