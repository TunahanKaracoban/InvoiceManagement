using InvoiceManagement.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceManagement.Entity.Dto
{
    public class DtoMonth:DtoBase
    {
        public DtoMonth()
        {
           
        }

        public int MonthId { get; set; }
        public string MonthName { get; set; }
    }
}
