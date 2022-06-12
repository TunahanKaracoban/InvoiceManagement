using InvoiceManagement.Entity.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace InvoiceManagement.Entity.Models
{
    public partial class Due : EntityBase
    {
        public int DuesId { get; set; }
        public int MonthId { get; set; }
        public int Year { get; set; }
        public decimal Amount { get; set; }
        public int ApartmentId { get; set; }
        public bool DuesStatus { get; set; }

        public virtual Apartment Apartment { get; set; }
        public virtual Month Month { get; set; }
    }
}
