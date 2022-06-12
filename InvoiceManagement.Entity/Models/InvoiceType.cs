using InvoiceManagement.Entity.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace InvoiceManagement.Entity.Models
{
    public partial class InvoiceType : EntityBase
    {
        public InvoiceType()
        {
            Invoices = new HashSet<Invoice>();
        }

        public int InvoiceTypeId { get; set; }
        public string InvoiceName { get; set; }

        public virtual ICollection<Invoice> Invoices { get; set; }
    }
}
