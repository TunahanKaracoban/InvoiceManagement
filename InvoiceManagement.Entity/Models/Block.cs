using InvoiceManagement.Entity.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace InvoiceManagement.Entity.Models
{
    public partial class Block : EntityBase
    {
        public Block()
        {
            Apartments = new HashSet<Apartment>();
        }

        public int BlockId { get; set; }
        public string BlockName { get; set; }

        public virtual ICollection<Apartment> Apartments { get; set; }
    }
}
