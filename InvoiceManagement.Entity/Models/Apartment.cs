using InvoiceManagement.Entity.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace InvoiceManagement.Entity.Models
{
    public partial class Apartment:EntityBase
    {
        public Apartment()
        {
            Dues = new HashSet<Due>();
            Invoices = new HashSet<Invoice>();
        }

        public int ApartmentId { get; set; }
        public int BlockId { get; set; }
        public int RoomTypeId { get; set; }
        public int UserId { get; set; }
        public byte FloorNumber { get; set; }
        public byte ApartmentNumber { get; set; }
        public bool? IsEmpty { get; set; }
        public string ApartmentStatus { get; set; }

        public virtual Block Block { get; set; }
        public virtual RoomType RoomType { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Due> Dues { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
    }
}
