using InvoiceManagement.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagement.Entity.Dto
{
    public class DtoInvoice : DtoBase
    {
        public int InvoiceId { get; set; }
        public int InvoiceTypeId { get; set; }
        public int MonthId { get; set; }
        public int Year { get; set; }
        public decimal Amount { get; set; }
        public int ApartmentId { get; set; }
        public bool InvoiceStatus { get; set; }
        public DateTime ExpirDate { get; set; }
    }
}
