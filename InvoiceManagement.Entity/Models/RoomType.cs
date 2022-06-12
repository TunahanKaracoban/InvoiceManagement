using InvoiceManagement.Entity.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace InvoiceManagement.Entity.Models
{
    public partial class RoomType : EntityBase
    {
        public RoomType()
        {
            Apartments = new HashSet<Apartment>();
        }

        public int RoomTypeId { get; set; }
        public string RoomType1 { get; set; }

        public virtual ICollection<Apartment> Apartments { get; set; }
    }
}
