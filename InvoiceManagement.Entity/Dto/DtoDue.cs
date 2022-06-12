using InvoiceManagement.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagement.Entity.Dto
{
    public class DtoDue:DtoBase
    {
        public int DuesId { get; set; }
        public int MonthId { get; set; }
        public string Year { get; set; }
        public decimal Amount { get; set; }
        public int ApartmentId { get; set; }
        public bool DuesStatus { get; set; }
    }
}
