using InvoiceManagement.Entity.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace InvoiceManagement.Entity.Models
{
    public partial class Invoice : EntityBase
    {
        public int InvoiceId { get; set; }
        public int InvoiceTypeId { get; set; }
        public int MonthId { get; set; }
        public int Year { get; set; }
        public decimal Amount { get; set; }
        public int ApartmentId { get; set; }
        public bool InvoiceStatus { get; set; }
        public DateTime ExpirDate { get; set; }

        public virtual Apartment Apartment { get; set; }
        public virtual InvoiceType InvoiceType { get; set; }
        public virtual Month Month { get; set; }
    }
}
