using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable disable

namespace Entity
{
    public partial class User
    {
        public User()
        {
            Orders = new HashSet<Order>();
        }

        public int UserId { get; set; }
        public string EmailUser { get; set; }
        public string PasswordUser { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneUser { get; set; }
        [JsonIgnore]
        public virtual ICollection<Order> Orders { get; set; }
    }
}
