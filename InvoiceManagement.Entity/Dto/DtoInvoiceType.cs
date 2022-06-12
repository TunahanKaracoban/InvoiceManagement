using InvoiceManagement.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagement.Entity.Dto
{
    public class DtoInvoiceType:DtoBase
    {
        public DtoInvoiceType()
        {
           
        }

        public int InvoiceTypeId { get; set; }
        public string InvoiceName { get; set; }
    }
}
