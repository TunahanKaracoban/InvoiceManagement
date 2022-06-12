using InvoiceManagement.Entity.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace InvoiceManagement.Entity.Models
{
    public partial class Month : EntityBase
    {
        public Month()
        {
            Dues = new HashSet<Due>();
            Invoices = new HashSet<Invoice>();
        }

        public int MonthId { get; set; }
        public string MonthName { get; set; }

        public virtual ICollection<Due> Dues { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
    }
}
