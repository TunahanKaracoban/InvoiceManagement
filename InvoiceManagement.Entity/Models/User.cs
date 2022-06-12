using InvoiceManagement.Entity.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace InvoiceManagement.Entity.Models
{
    public partial class User : EntityBase
    {
        public User()
        {
            Apartments = new HashSet<Apartment>();
            MessageReceivers = new HashSet<Message>();
            MessageSenders = new HashSet<Message>();
        }

        public int UserId { get; set; }
        public int RoleId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string IdentityNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string NumberPlate { get; set; }

        public virtual Role Role { get; set; }
        public virtual ICollection<Apartment> Apartments { get; set; }
        public virtual ICollection<Message> MessageReceivers { get; set; }
        public virtual ICollection<Message> MessageSenders { get; set; }
    }
}
