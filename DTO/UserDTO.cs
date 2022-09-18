using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable disable

namespace Entity
{
    public partial class UserDTO
    {

        public int UserId { get; set; }
        public string EmailUser { get; set; }
        public string PasswordUser { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneUser { get; set; }
       
      
    }
}
